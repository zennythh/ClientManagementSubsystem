using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.classes;

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
                            DateSubmitted = reader.GetDateTime("DateSubmitted")
                        });
                    }
                }
            }
            return conflicts;
        }
    }
}
