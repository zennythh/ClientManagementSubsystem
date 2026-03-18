using System;
using System.Drawing;
using System.Windows.Forms;
using ClientManagementSubsystem.Models;

namespace ClientManagementSubsystem.userControls
{
    public partial class BookingCard : UserControl
    {
        public event EventHandler OnSelect;

        // Stores the full data for later use (e.g. double-clicking to open details)
        public Booking BookingData { get; private set; }

        public BookingCard()
        {
            InitializeComponent();
            this.Click += Card_Clicked;
            WireAllControls(this);
        }

        public void Populate(Booking booking)
        {
            this.BookingData = booking;

            // Basic Info
            this.ClientName = booking.FullName;
            this.BookingID = booking.BookingID;

            // Dates Section
            lblDateOut.Text = booking.DateSchedOut.ToString("MMM dd, hh:mm tt");
            lblDateIn.Text = booking.DateDue.ToString("MMM dd, hh:mm tt");
            lblTimeAgo.Text = GetTimeAgo(booking.DateSubmitted);
        }


        // Helper to make the "Time Ago" look natural
        private string GetTimeAgo(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalMinutes < 1) return "Just now";
            if (timeSpan.TotalMinutes < 60) return $"{(int)timeSpan.TotalMinutes} minutes ago";
            if (timeSpan.TotalHours < 24) return $"{(int)timeSpan.TotalHours} hours ago";

            return dateTime.ToString("MMM dd"); // Fallback to date if older than a day
        }

        private void WireAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += Card_Clicked;
                if (c.HasChildren) WireAllControls(c);
            }
        }

        private void Card_Clicked(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        // --- Properties linked to Labels ---
        public string VehicleName { get { return lblVehicle.Text; } set { lblVehicle.Text = value; } }
        public string ClientName { get { return lblClient.Text; } set { lblClient.Text = value; } }

        public int BookingID
        {
            get => int.TryParse(lblBookingNum.Text, out int id) ? id : -1;
            set => lblBookingNum.Text = value.ToString();
        }
    }
}