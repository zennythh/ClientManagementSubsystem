using ClientManagementSubsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementSubsystem.userControls
{
    public partial class ConflictBookingCard : UserControl
    {
        public ConflictBookingCard()
        {
            InitializeComponent();
        }

        public void Populate(Booking b)
        {
            lblBookingID.Text = b.BookingID.ToString();
            lblCustomerName.Text = b.FullName;

            lblRentalStartDate.Text = b.DateSchedOut.ToString("MM/dd/yyyy");
            lblRentalEndDate.Text = b.DateDue.ToString("MM/dd/yyyy");
            lblTimeAgo.Text = GetTimeAgo(b.DateSubmitted);

            // UI Polish: If it's a conflict, maybe give it a subtle red border or background
            this.BackColor = Color.FromArgb(255, 235, 235); // Very light red
        }

        private string GetTimeAgo(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalMinutes < 1) return "Just now";
            if (timeSpan.TotalMinutes < 2) return "a minute ago";
            if (timeSpan.TotalMinutes < 60) return $"{(int)timeSpan.TotalMinutes} minutes ago";
            if (timeSpan.TotalHours < 2) return "an hour ago";
            if (timeSpan.TotalHours < 24) return $"{(int)timeSpan.TotalHours} hours ago";
            if (timeSpan.TotalDays < 2) return "Yesterday";
            if (timeSpan.TotalDays < 7) return $"{(int)timeSpan.TotalDays} days ago";

            return dateTime.ToString("MMM dd");
        }
    }
}
