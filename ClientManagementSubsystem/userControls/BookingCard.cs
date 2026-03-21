using System;
using System.Drawing;
using System.Windows.Forms;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.classes;

namespace ClientManagementSubsystem.userControls
{
    public partial class BookingCard : UserControl
    {
        public event EventHandler OnSelect;

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

            this.ClientName = booking.FullName;
            this.BookingID = booking.BookingID;

            lblDateOut.Text = booking.DateSchedOut.ToString("MMM dd, hh:mm tt");
            lblDateIn.Text = booking.DateDue.ToString("MMM dd, hh:mm tt");
            lblTimeAgo.Text = booking.DateSubmitted.ToTimeAgo();

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

        public string VehicleName { get { return lblVehicle.Text; } set { lblVehicle.Text = value; } }
        public string ClientName { get { return lblClient.Text; } set { lblClient.Text = value; } }

        public int BookingID
        {
            get => int.TryParse(lblBookingNum.Text, out int id) ? id : -1;
            set => lblBookingNum.Text = value.ToString();
        }
    }
}