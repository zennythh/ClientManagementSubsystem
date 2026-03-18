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
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }

        // Customer Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Vehicle Details (The stuff the Clerk checks against the lot)
        public string VehicleVIN { get; set; }
        public string VehicleName { get; set; } 
        public string LicensePlate { get; set; }
        public string ImagePath { get; set; } 
        // Schedule Details
        public DateTime DateSchedOut { get; set; }
        public DateTime DateDue { get; set; }

        // UI Helper for Age (Useful for insurance verification)
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
    }
}
