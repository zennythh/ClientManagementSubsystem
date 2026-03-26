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
        private Booking MapReaderToBooking(MySqlDataReader reader)
        {
            string vehicleNameCol = "FullVehicleName";
            if (reader.GetSchemaTable().Select("ColumnName = 'VehicleName'").Length > 0)
                vehicleNameCol = "VehicleName";

            var booking = new Booking
            {
                BookingID = reader.GetInt32("BookingID"),
                FirstName = reader.GetString("FirstName"),
                LastName = reader.GetString("LastName"),
                LicenseNumber = reader.GetString("LicenseNum"),
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

                // Nullable Dates
                DateOut = reader.IsDBNull(reader.GetOrdinal("DateOut")) ? (DateTime?)null : reader.GetDateTime("DateOut"),
                DateIn = reader.IsDBNull(reader.GetOrdinal("DateIn")) ? (DateTime?)null : reader.GetDateTime("DateIn"),

                // Usage Metrics
                MileageOut = reader.IsDBNull(reader.GetOrdinal("MileageOut")) ? (int?)null : reader.GetInt32("MileageOut"),
                MileageIn = reader.IsDBNull(reader.GetOrdinal("MileageIn")) ? (int?)null : reader.GetInt32("MileageIn"),
                FuelLevelOut = reader.IsDBNull(reader.GetOrdinal("FuelLevelOut")) ? null : reader.GetString("FuelLevelOut"),
                FuelLevelIn = reader.IsDBNull(reader.GetOrdinal("FuelLevelIn")) ? null : reader.GetString("FuelLevelIn"),

                // Prices
                AdditionalFees = reader.IsDBNull(reader.GetOrdinal("AdditionalFees")) ? (decimal?)null : reader.GetDecimal("AdditionalFees"),
                TotalPrice = reader.IsDBNull(reader.GetOrdinal("TotalPrice")) ? (decimal?)null : reader.GetDecimal("TotalPrice")
            };

            // --- DAMAGE DETECTION LOGIC ---
            // Check if our query included the DamageCount column (only exists for Completed status)
            if (reader.GetSchemaTable().Select("ColumnName = 'DamageCount'").Length > 0)
            {
                int damageCount = reader.IsDBNull(reader.GetOrdinal("DamageCount")) ? 0 : Convert.ToInt32(reader["DamageCount"]);
                booking.HasDamage = damageCount > 0;
            }

            return booking;
        }

        public List<Booking> GetBookingsByStatus(string status)
        {
            List<Booking> list = new List<Booking>();

            // Base query for basic status checks
            string query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate
                             FROM Bookings b
                             JOIN Vehicles v ON b.VehicleVIN = v.VIN
                             WHERE b.Status = @status AND b.Deleted = 0";

            // If we are looking for Completed bookings, we subquery the damage table
            if (status == "Completed")
            {
                query = @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath, v.DailyRate,
                          (SELECT COUNT(*) 
                           FROM VehicleDamages vd 
                           JOIN VehicleInspections vi ON vd.InspectionID = vi.InspectionID 
                           WHERE vi.BookingID = b.BookingID) AS DamageCount
                          FROM Bookings b
                          JOIN Vehicles v ON b.VehicleVIN = v.VIN
                          WHERE b.Status = @status AND b.Deleted = 0";
            }

            query += " ORDER BY b.DateIn DESC, b.DateSubmitted DESC";

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

                        // 4. APPROVE CURRENT BOOKING (DateOfBirth column removed)
                        string updateBooking = @"UPDATE Bookings SET 
                        FirstName=@fn, LastName=@ln, LicenseNum=@lic, Email=@em, PhoneNumber=@ph, 
                        DateSchedOut=@start, DateDue=@due, 
                        ProjectedPrice=@price, Status='Reserved' 
                        WHERE BookingID=@bid";

                        using (var cmd = new MySqlCommand(updateBooking, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@fn", info.FirstName);
                            cmd.Parameters.AddWithValue("@ln", info.LastName);
                            cmd.Parameters.AddWithValue("@lic", info.LicenseNumber);
                            cmd.Parameters.AddWithValue("@em", info.Email);
                            cmd.Parameters.AddWithValue("@ph", info.PhoneNumber);
                            cmd.Parameters.AddWithValue("@start", info.DateSchedOut);
                            cmd.Parameters.AddWithValue("@due", info.DateDue);
                            cmd.Parameters.AddWithValue("@price", info.ProjectedPrice);
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
                    string query = "UPDATE Bookings SET Status = 'Rejected' WHERE BookingID = @bid" +
                                   "UPDATE Bookings SET Status = 'Rejected' WHERE BookingID = @bid; " +
                                   "UPDATE Vehicles SET CurrentStatus = 'Available' WHERE VIN = (SELECT VehicleVIN FROM Bookings WHERE BookingID = @bid);";
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

        public (bool success, string message) ProcessUnitRelease(int bookingID, string vin, int mileageOut, string fuelOut)
        {
            using (var connection = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update Booking status and metrics
                        string updateBooking = @"UPDATE Bookings SET 
                                        Status = 'Out', 
                                        DateOut = @dateOut, 
                                        MileageOut = @mOut, 
                                        FuelLevelOut = @fOut 
                                        WHERE BookingID = @bid";

                        using (var cmd = new MySqlCommand(updateBooking, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dateOut", DateTime.Now);
                            cmd.Parameters.AddWithValue("@mOut", mileageOut);
                            cmd.Parameters.AddWithValue("@fOut", fuelOut);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update Vehicle status to 'Out' 
                        // (Optional: You might already have 'Rented' from the Approval stage, 
                        // but 'Out' is more specific for active driving)
                        string updateVehicle = "UPDATE Vehicles SET CurrentStatus = 'Out' WHERE VIN = @vin";
                        using (var cmd = new MySqlCommand(updateVehicle, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@vin", vin);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return (true, "Vehicle successfully released!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, $"Database Error: {ex.Message}");
                    }
                }
            }
        }

        public bool SaveFullInspection(int bookingID, string vin, string notes, string damages, List<string> imagePaths)
        {
            using (var conn = new MySqlConnection(MySQLConnStr.ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Create the Parent Inspection Record
                        string insertInspection = @"INSERT INTO VehicleInspections (VIN, BookingID, GeneralNotes, InspectedAt) 
                                           VALUES (@vin, @bid, @notes, @at);
                                           SELECT LAST_INSERT_ID();";

                        int inspectionID;
                        using (var cmd = new MySqlCommand(insertInspection, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@vin", vin);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            cmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes);
                            cmd.Parameters.AddWithValue("@at", DateTime.Now);
                            inspectionID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Insert Damage Description (Only if there is text provided)
                        if (!string.IsNullOrWhiteSpace(damages))
                        {
                            string insertDamage = "INSERT INTO VehicleDamages (InspectionID, Description) VALUES (@iid, @desc)";
                            using (var cmd = new MySqlCommand(insertDamage, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@iid", inspectionID);
                                cmd.Parameters.AddWithValue("@desc", damages);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 3. Insert Multiple Images into InspectionImages table
                        if (imagePaths != null && imagePaths.Count > 0)
                        {
                            string insertImg = "INSERT INTO InspectionImages (InspectionID, ImageFileName) VALUES (@iid, @file)";
                            foreach (string path in imagePaths)
                            {
                                using (var cmd = new MySqlCommand(insertImg, conn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@iid", inspectionID);
                                    cmd.Parameters.AddWithValue("@file", path);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // 4. Update Booking Status to 'Completed' and set DateIn
                        string updateBooking = "UPDATE Bookings SET Status = 'Completed', DateIn = @now WHERE BookingID = @bid";
                        using (var cmd = new MySqlCommand(updateBooking, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@bid", bookingID);
                            cmd.ExecuteNonQuery();
                        }

                        // 5. Release Vehicle back to 'Available'
                        string updateVehicle = "UPDATE Vehicles SET CurrentStatus = 'Available' WHERE VIN = @vin";
                        using (var cmd = new MySqlCommand(updateVehicle, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@vin", vin);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        // Optional: Log ex.Message for debugging
                        return false;
                    }
                }
            }
        }
    }
}
