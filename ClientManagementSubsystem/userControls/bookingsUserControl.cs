using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementSubsystem
{
    public partial class bookingsUserControl : UserControl
    {
        BookingHandler db = new BookingHandler();
        private Booking originalBooking;
        private PendingInfos currentPendingInfo;

        public bookingsUserControl()
        {
            InitializeComponent();
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
            LoadBookingCards();
            // LoadBookings(); for noDB test purposes
        }

        private void LoadBookingCards()
        {
            try
            {
                List<Booking> bookings = db.GetBookingsByStatus("Pending");
                bookingListPanel.Controls.Clear();

                foreach (Booking booking in bookings)
                {
                    BookingCard card = new BookingCard();
                    card.Populate(booking);
                    card.VehicleName = booking.VehicleName;

                    card.OnSelect += (s, e) =>
                    {
                        BookingCard clickedCard = (BookingCard)s;

                        originalBooking = clickedCard.BookingData;

                        currentPendingInfo = MapToPendingInfo(originalBooking);

                        DisplayBookingDetails(currentPendingInfo);
                    };

                    bookingListPanel.Controls.Add(card);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            CenterCards();
        }

        private PendingInfos MapToPendingInfo(Booking b)
        {
            return new PendingInfos
            {
                BookingID = b.BookingID,
                FirstName = b.FirstName,
                LastName = b.LastName,
                LicenseNumber = b.LicenseNumber,
                DateOfBirth = b.DateOfBirth,
                Email = b.Email,
                PhoneNumber = b.PhoneNumber,
                VehicleVIN = b.VehicleVIN,
                VehicleName = b.VehicleName,
                LicensePlate = b.LicensePlate,
                ImagePath = b.ImagePath,
                DateSchedOut = b.DateSchedOut,
                DateDue = b.DateDue,
                DateSubmitted = b.DateSubmitted
            };
        }

        private void DisplayBookingDetails(PendingInfos b)
        {
            lblBookingIDValue.Text = b.BookingID.ToString();
            firstNameTextBox.Text = b.FirstName;
            lastNameTextBox.Text = b.LastName;
            customerLicenseTextBox.Text = b.LicenseNumber;
            customerEmailTextBox.Text = b.Email;
            customerContactNumTextBox.Text = b.PhoneNumber;
            customerBdayDTP.Value = b.DateOfBirth;
            customerAgeTextBox.Text = b.Age.ToString();

            lblDateofRequestValue.Text = GetRequestDate(b.DateSubmitted);

            vehicleLicenseTextBox.Text = b.LicensePlate;
            vehicleNameTextBox.Text = b.VehicleName;

            rentalDateStartDTP.Value = b.DateSchedOut;
            rentalDateEndDTP.Value = b.DateDue;

            lblRentalTimeValue.Text = GetRentalDuration(b.DateSchedOut, b.DateDue);

            if (!string.IsNullOrEmpty(b.ImagePath) && System.IO.File.Exists(b.ImagePath))
            {
                // Loading manually into the Image property preserves the Zoom mode better
                vehiclePictureBox.Image = Image.FromFile(b.ImagePath);
            }
            else
            {
                // Explicitly set the resource as the main Image
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;
            }
        }

        private string GetRequestDate(DateTime date)
        {
            DateTime now = DateTime.Now;

            if (date.Date == now.Date)
            {
                return $"Today at {date:hh:mm tt}";
            }
            else if (date.Date == now.AddDays(-1).Date)
            {
                return $"Yesterday at {date:hh:mm tt}";
            }
            else
            {
                return date.ToString("MM/dd/yyyy hh:mm tt");
            }
        }

        private string GetRentalDuration(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;

            if (duration.TotalSeconds <= 0) return "Invalid Duration";

            int days = duration.Days;
            int hours = duration.Hours;

            string dayPart = days > 0 ? $"{days} {(days == 1 ? "Day" : "Days")}" : "";
            string hourPart = hours > 0 ? $"{hours} {(hours == 1 ? "Hour" : "Hours")}" : "";

            if (days > 0 && hours > 0) return $"{dayPart}, {hourPart}";
            return string.IsNullOrEmpty(dayPart) ? hourPart : dayPart;
        }

        public void LoadBookings()
        {
            bookingListPanel.Controls.Clear();
            bookingListPanel.SuspendLayout();

            for (int i = 0; i < 12; i++)
            {
                BookingCard card = new BookingCard();

                card.VehicleName = "Toyota Vios";
                card.ClientName = "John Doe";
                card.BookingID = i;

                card.OnSelect += (s, e) =>
                {
                    MessageBox.Show($"You clicked booking #{card.BookingID}");
                };

                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }

        private void CenterCards()
        {
            if (bookingListPanel.Controls.Count == 0) return;

            Control firstCard = bookingListPanel.Controls[0];

            int cardFullWidth = firstCard.Width + firstCard.Margin.Horizontal;
            int availableWidth = bookingListPanel.ClientSize.Width - bookingListPanel.Padding.Horizontal;
            int cardsPerRow = availableWidth / cardFullWidth;
            if (cardsPerRow <= 0) cardsPerRow = 1;
            int totalContentWidth = cardsPerRow * cardFullWidth;
            int lateralPadding = (bookingListPanel.ClientSize.Width - totalContentWidth) / 2;

            bookingListPanel.Padding = new Padding(Math.Max(0, lateralPadding), bookingListPanel.Padding.Top, 0, 0);
        }

        // Button clicks
        private void pendingBtn_Click(object sender, EventArgs e)
        {
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
        }

        private void approvedBtn_Click(object sender, EventArgs e)
        {
            approvedSelected.Visible = true;
            pendingSelected.Visible = false;
        }

    }
}
