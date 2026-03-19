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
    internal class DatabaseManager
    {
        public List<Booking> GetBookingsByStatus(string status)
        {
            List<Booking> list = new List<Booking>();
            string query =
        @"SELECT b.*, CONCAT(v.Manufacturer, ' ', v.Model) AS FullVehicleName, v.LicensePlate, v.ImagePath
        FROM Bookings b
        JOIN Vehicles v ON b.VehicleVIN = v.VIN
        WHERE b.Status = @status
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

                            // Handle Nullables safely
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
    }
}
