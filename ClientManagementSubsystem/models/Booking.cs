using System;

namespace ClientManagementSubsystem.Models
{
    public class Booking
    {
        // Customer Info
        public int BookingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        // Vehicle Info
        public string VehicleVIN { get; set; }
        public string VehicleName { get; set; }
        public string LicensePlate { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        // Dates
        public DateTime DateSubmitted { get; set; }
        public DateTime DateSchedOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime? DateOut { get; set; } 
        public DateTime? DateIn { get; set; }  
        // Usage Metrics
        public int? MileageOut { get; set; }
        public int? MileageIn { get; set; }
        public string FuelLevelOut { get; set; }
        public string FuelLevelIn { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string DisplayDates => Status == "Out"
            ? $"Due: {DateDue:MMM dd, yyyy}"
            : $"Scheduled: {DateSchedOut:MMM dd, yyyy}";

        public string TotalDistance
        {
            get
            {
                if (MileageIn.HasValue && MileageOut.HasValue)
                    return (MileageIn.Value - MileageOut.Value).ToString() + " km";
                return "N/A";
            }
        }
    }
}