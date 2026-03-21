using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientManagementSubsystem.classes
{
    internal class BookingHandler
    {
        // --- THE MAPPING HELPER ---
        private Booking MapReaderToBooking(MySqlDataReader reader)
        {
            // First, identify columns that might have different names depending on the JOIN
            // In some queries you use 'FullVehicleName', in others 'VehicleName'
            string vehicleNameCol = "FullVehicleName";
            if (reader.GetSchemaTable().Select("ColumnName = 'VehicleName'").Length > 0)
                vehicleNameCol = "VehicleName";

            return new Booking
            {
                BookingID = reader.GetInt32("BookingID"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                LicenseNumber = reader.GetString("LicenseNum"),
                DateOfBirth = reader.GetDateTime("DateOfBirth"),
                Email = reader.GetString("Email"),
                PhoneNumber = reader.GetString("PhoneNumber"),
                VehicleVIN = reader.GetString("VehicleVIN"),
                VehicleName = reader.GetString(vehicleNameCol),
                LicensePlate = reader.GetString("LicensePlate"),
                ImagePath = reader.GetString("ImagePath"),
                Status = reader.GetString("Status"),
                DateSubmitted = reader.GetDateTime("DateSubmitted"),
                DateSchedOut = reader.GetDateTime("DateSchedOut"),
                DateDue = reader.GetDateTime("DateDue"),
                DailyRate = reader.GetDecimal("DailyRate"),
                ProjectedPrice = reader.GetDecimal("ProjectedPrice"),

                // Nullables
                DateOut = reader.IsDBNull(reader.GetOrdinal("DateOut")) ? (DateTime?)null : reader.GetDateTime("DateOut"),
                DateIn = reader.IsDBNull(reader.GetOrdinal("DateIn")) ? (DateTime?)null : reader.GetDateTime("DateIn"),
                MileageOut = reader.IsDBNull(reader.GetOrdinal("MileageOut")) ? (int?)null : reader.GetInt32("MileageOut"),
                MileageIn = reader.IsDBNull(reader.GetOrdinal("MileageIn")) ? (int?)null : reader.GetInt32("MileageIn"),
                FuelLevelOut = reader.IsDBNull(reader.GetOrdinal("FuelLevelOut")) ? null : reader.GetString("FuelLevelOut"),
                FuelLevelIn = reader.IsDBNull(reader.GetOrdinal("FuelLevelIn")) ? null : reader.GetString("FuelLevelIn"),
                AdditionalFees = reader.IsDBNull(reader.GetOrdinal("AdditionalFees")) ? (decimal?)null : reader.GetDecimal("AdditionalFees"),
                TotalPrice = reader.IsDBNull(reader.GetOrdinal("TotalPrice")) ? (decimal?)null : reader.GetDecimal("TotalPrice")
            };
        }

        public List<Booking> GetBookingsByStatus(string status)
        {
            List<Booking> list = new List<Booking>();
            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate
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
                        list.Add(MapReaderToBooking(reader));
                    }
                }
            }
            return list;
        }

        public List<Booking> SearchBookings(string searchTerm, string status = "Pending")
        {
            List<Booking> results = new List<Booking>();
            using (var connection = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = $@"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS VehicleName, v.LicensePlate, v.ImagePath, v.DailyRate 
                             FROM Bookings b
                             JOIN Vehicles v ON b.VehicleVIN = v.VIN
                             WHERE b.Status = @status AND b.Deleted = 0
                             AND (
                                 b.BookingID LIKE @search OR
                                 b.FirstName LIKE @search OR
                                 b.LastName LIKE @search OR
                                 CONCAT(b.FirstName, ' ', b.LastName) LIKE @search OR
                                 b.LicenseNum LIKE @search OR
                                 b.Email LIKE @search OR
                                 b.PhoneNumber LIKE @search
                             )";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                results.Add(MapReaderToBooking(reader));
                            }
                        }
                    }
                }
                catch (Exception) { /* Handle log */ }
            }
            return results;
        }

        public static List<Booking> GetConflictingBookings(int currentBookingID, string vin, DateTime requestedStart, DateTime requestedEnd)
        {
            List<Booking> conflicts = new List<Booking>();
            int bufferHours = 3;

            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS VehicleName, v.LicensePlate, v.ImagePath, v.DailyRate 
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

                // Since MapReaderToBooking is instance-based and this is static, 
                // we create a temporary instance or just map manually here.
                // Recommendation: Make MapReaderToBooking public/internal static.
                var handler = new BookingHandler();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        conflicts.Add(handler.MapReaderToBooking(reader));
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
                        DateOfBirth=@dob, DateSchedOut=@start, DateDue=@due, 
                        ProjectedPrice=@price, Status='Reserved' 
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
                            cmd.Parameters.AddWithValue("@price", info.ProjectedPrice); // <-- ADD THIS
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

        public (bool success, string message) ProcessRejection(int bookingID)
        {
            using (var connection = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Bookings SET Status = 'Rejected' WHERE BookingID = @bid";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@bid", bookingID);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            return (true, "Booking has been rejected.");
                        else
                            return (false, "Booking not found or already updated.");
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"Database Error: {ex.Message}");
                }
            }
        }
    }
}
