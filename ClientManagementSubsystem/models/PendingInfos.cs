using ClientManagementSubsystem.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSubsystem.models
{
    internal class PendingInfos
    {
        // Identification
        public int BookingID { get; set; }
        public DateTime DateSubmitted { get; set; }

        // Customer Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Vehicle Details 
        public string VehicleVIN { get; set; }
        public string VehicleName { get; set; } 
        public string LicensePlate { get; set; }
        public string ImagePath { get; set; } 
        public string FullImagePath  => System.IO.Path.Combine(ClientManagementSubsystem.classes.RoamingPath.roamingBase, "CarRentalApp", ImagePath);

        public decimal ProjectedPrice { get; set; }
        public decimal DailyRate { get; set; }

        // Schedule Details
        public DateTime DateSchedOut { get; set; }
        public DateTime DateDue { get; set; }

        // UI Helper for Age (Useful for insurance verification)
        // Inside PendingInfos.cs
        }
}
