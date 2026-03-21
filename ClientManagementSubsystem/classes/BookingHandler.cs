using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using MySql.Data.MySqlClient; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSubsystem.classes
{
    internal class BookingHandler
    {
        public List<Booking> GetBookingsByStatus(string status)
        {
            List<Booking> list = new List<Booking>();
            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath
                            FROM Bookings b
                            JOIN Vehicles v ON b.VehicleVIN = v.VIN
                            WHERE b.Status = @status AND b.Deleted = 0
                            ORDER BY b.DateSubmitted DESC";

            using (var conn = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Booking
                        {
                            BookingID = reader.GetInt32("BookingID"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            LicenseNumber = reader.GetString("LicenseNum"),
                            DateOfBirth = reader.GetDateTime("DateOfBirth"),
                            Email = reader.GetString("Email"),
                            PhoneNumber = reader.GetString("PhoneNumber"),
                            VehicleVIN = reader.GetString("VehicleVIN"),
                            VehicleName = reader.GetString("FullVehicleName"),
                            LicensePlate = reader.GetString("LicensePlate"),
                            ImagePath = reader.GetString("ImagePath"),
                            Status = reader.GetString("Status"),
                            DateSubmitted = reader.GetDateTime("DateSubmitted"),
                            DateSchedOut = reader.GetDateTime("DateSchedOut"),
                            DateDue = reader.GetDateTime("DateDue"),

                            // Nullables
                            DateOut = reader.IsDBNull(reader.GetOrdinal("DateOut")) ? (DateTime?)null : reader.GetDateTime("DateOut"),
                            DateIn = reader.IsDBNull(reader.GetOrdinal("DateIn")) ? (DateTime?)null : reader.GetDateTime("DateIn"),
                            MileageOut = reader.IsDBNull(reader.GetOrdinal("MileageOut")) ? (int?)null : reader.GetInt32("MileageOut"),
                            MileageIn = reader.IsDBNull(reader.GetOrdinal("MileageIn")) ? (int?)null : reader.GetInt32("MileageIn"),
                            FuelLevelOut = reader.IsDBNull(reader.GetOrdinal("FuelLevelOut")) ? null : reader.GetString("FuelLevelOut"),
                            FuelLevelIn = reader.IsDBNull(reader.GetOrdinal("FuelLevelIn")) ? null : reader.GetString("FuelLevelIn")
                        });
                    }
                }
            }
            return list;
        }

        public static List<Booking> GetConflictingBookings(int currentBookingID, string vin, DateTime requestedStart, DateTime requestedEnd)
        {
            List<Booking> conflicts = new List<Booking>();
            int bufferHours = 3;

            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS VehicleName 
                    FROM Bookings b
                    JOIN Vehicles v ON b.VehicleVIN = v.VIN
                    WHERE b.VehicleVIN = @vin 
                    AND b.Status IN ('Pending', 'Reserved', 'Out')
                    AND @RequestedStart < DATE_ADD(b.DateDue, INTERVAL @Buffer HOUR)
                    AND @RequestedEnd > b.DateSchedOut
                    AND b.BookingID != @CurrentBookingID 
                    AND b.Deleted = 0";

            using (var conn = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CurrentBookingID", currentBookingID);
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@RequestedStart", requestedStart);
                cmd.Parameters.AddWithValue("@RequestedEnd", requestedEnd);
                cmd.Parameters.AddWithValue("@Buffer", bufferHours);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        conflicts.Add(new Booking
                        {
                            BookingID = reader.GetInt32("BookingID"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            VehicleName = reader.GetString("VehicleName"),
                            DateSchedOut = reader.GetDateTime("DateSchedOut"),
                            DateDue = reader.GetDateTime("DateDue"),
                            DateSubmitted = reader.GetDateTime("DateSubmitted"),
                            Status = reader.GetString("Status") 
                        });
                    }
                }
            }
            return conflicts;
        }

        public (bool success, string message) ProcessApproval(PendingInfos info)
        {
            using (var connection = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var conflicts = GetConflictingBookings(info.BookingID, info.VehicleVIN, info.DateSchedOut, info.DateDue);

                        // --- THE SAFETY FILTER ---
                        // We ONLY auto-reject bookings that are 'Pending'. 
                        // 'Reserved' or 'Out' bookings are left alone (the staff handles the buffer manually).
                        var bookingsToReject = conflicts.Where(c => c.Status == "Pending").ToList();

                        // 2. CATEGORY CHECK: Hard Block
                        // If there's a DIRECT overlap with Reserved/Out, we still block the approval.
                        // Note: We only block if the overlap is REAL (requested start < their due date).
                        bool hasHardDirectConflict = conflicts.Any(c =>
                            (c.Status == "Reserved" || c.Status == "Out") &&
                            info.DateSchedOut < c.DateDue);

                        if (hasHardDirectConflict)
                        {
                            return (false, "🛑 CANNOT APPROVE: Direct overlap with an active/reserved booking.");
                        }

                        // 3. AUTO-REJECT: Only for PENDING conflicts
                        if (bookingsToReject.Count > 0)
                        {
                            string ids = string.Join(",", bookingsToReject.Select(c => c.BookingID));
                            string rejectQuery = $"UPDATE Bookings SET Status = 'Rejected' WHERE BookingID IN ({ids})";

                            using (var cmd = new MySqlCommand(rejectQuery, connection, transaction))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 4. APPROVE CURRENT BOOKING
                        string updateBooking = @"UPDATE Bookings SET 
                                                FirstName=@fn, LastName=@ln, LicenseNum=@lic, Email=@em, PhoneNumber=@ph, 
                                                DateOfBirth=@dob, DateSchedOut=@start, DateDue=@due, Status='Reserved' 
                                                WHERE BookingID=@bid";
                            
                        using (var cmd = new MySqlCommand(updateBooking, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@fn", info.FirstName);
                            cmd.Parameters.AddWithValue("@ln", info.LastName);
                            cmd.Parameters.AddWithValue("@lic", info.LicenseNumber);
                            cmd.Parameters.AddWithValue("@em", info.Email);
                            cmd.Parameters.AddWithValue("@ph", info.PhoneNumber);
                            cmd.Parameters.AddWithValue("@dob", info.DateOfBirth);
                            cmd.Parameters.AddWithValue("@start", info.DateSchedOut);
                            cmd.Parameters.AddWithValue("@due", info.DateDue);
                            cmd.Parameters.AddWithValue("@bid", info.BookingID);
                            cmd.ExecuteNonQuery();
                        }

                        // 5. UPDATE VEHICLE STATUS
                        string updateVehicle = "UPDATE Vehicles SET CurrentStatus = 'Rented' WHERE VIN = @vin";
                        using (var cmd = new MySqlCommand(updateVehicle, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@vin", info.VehicleVIN);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return (true, "Approval successful. Conflicting pending requests have been automatically rejected.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, $"Database Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
