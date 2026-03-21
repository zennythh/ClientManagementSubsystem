using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientManagementSubsystem
{
    public partial class bookingsUserControl : UserControl
    {
        BookingHandler db = new BookingHandler();
        private Booking originalBooking;
        private PendingInfos currentPendingInfo;
        private bool isSyncing = false; 

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
        // DBLESS TEST PURPOSES!!
        // UNCOMMENT THE LoadBookingCards() CALL IN THE CONSTRUCTOR TO USE THIS
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
            string imagePath = Path.Combine(RoamingPath.roamingBase, "CarRentalApp");

            // Fill details section with booking info
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

            isSyncing = true; 
            rentalDateStartDTP.Value = b.DateSchedOut;
            rentalDateEndDTP.Value = b.DateDue;
            isSyncing = false;

            lblRentalTimeValue.Text = GetRentalDuration(b.DateSchedOut, b.DateDue);

            if (!string.IsNullOrEmpty(b.FullImagePath) && System.IO.File.Exists(b.FullImagePath))
            {
                vehiclePictureBox.ImageLocation = b.FullImagePath;
            }
            else
            {
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;
            }

            // Query for conflicts

            conflictFlowPanel.Controls.Clear();
            lblBookingConflicts.Visible = false;
            lblNoBookingConflicts.Visible = false;

            var conflicts = BookingHandler.GetConflictingBookings(
                            b.BookingID,
                            b.VehicleVIN,
                            rentalDateStartDTP.Value,
                            rentalDateEndDTP.Value
                            );

            if (conflicts.Count > 0)
            {
                lblBookingConflicts.Visible = true;
                foreach (var conflict in conflicts)
                {
                    ConflictBookingCard miniCard = new ConflictBookingCard();

                    miniCard.Populate(conflict);

                    conflictFlowPanel.Controls.Add(miniCard);
                }
                CenterConflictCards();
            }
            else
            {
                lblBookingConflicts.Visible = false;

                if (!conflictFlowPanel.Controls.Contains(lblNoBookingConflicts))
                {
                    conflictFlowPanel.Controls.Add(lblNoBookingConflicts);
                }
                lblNoBookingConflicts.Visible = true;
                //lblNoBookingConflicts.Margin = new Padding((conflictFlowPanel.Width - lblNoBookingConflicts.Width) / 2, 20, 0, 0);
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

            if (duration.TotalSeconds <= 0)
            {
                lblRentalTimeValue.ForeColor = Color.Red;
                return "Invalid Duration";
            }

            int days = duration.Days;
            int hours = duration.Hours;

            string dayPart = days > 0 ? $"{days} {(days == 1 ? "Day" : "Days")}" : "";
            string hourPart = hours > 0 ? $"{hours} {(hours == 1 ? "Hour" : "Hours")}" : "";

            if (days > 0 && hours > 0) return $"{dayPart}, {hourPart}";
            lblRentalTimeValue.ForeColor = Color.Black;
            return string.IsNullOrEmpty(dayPart) ? hourPart : dayPart;
        }

        private void RefreshConflictSection()

        {
            if (currentPendingInfo == null) return;
            lblRentalTimeValue.Text = GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            conflictFlowPanel.Controls.Clear();
            lblBookingConflicts.Visible = false;
            lblNoBookingConflicts.Visible = false;

            var conflicts = BookingHandler.GetConflictingBookings(
                            currentPendingInfo.BookingID,
                            currentPendingInfo.VehicleVIN,
                            rentalDateStartDTP.Value,
                            rentalDateEndDTP.Value
                            );
            // Repopulate the panel

            if (conflicts.Count > 0)
            {
                lblBookingConflicts.Visible = true;
                foreach (var conflict in conflicts)
                {
                    ConflictBookingCard miniCard = new ConflictBookingCard();
                    miniCard.Populate(conflict);
                    conflictFlowPanel.Controls.Add(miniCard);
                }
                CenterConflictCards();
            }
            else
            {

                if (!conflictFlowPanel.Controls.Contains(lblNoBookingConflicts))
                {
                    conflictFlowPanel.Controls.Add(lblNoBookingConflicts);
                }
                lblNoBookingConflicts.Visible = true;
                lblNoBookingConflicts.Margin = new Padding((conflictFlowPanel.Width - lblNoBookingConflicts.Width) / 2, 20, 0, 0);

            }

        }



        // Centering the cards
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

        private void CenterConflictCards()
        {
            int totalCardsWidth = 0;
            foreach (Control card in conflictFlowPanel.Controls)
            {
                totalCardsWidth += card.Width + card.Margin.Horizontal;
            }

            if (totalCardsWidth + 20 < conflictFlowPanel.Width)
            {
                int offset = (conflictFlowPanel.Width - totalCardsWidth) / 2;
                conflictFlowPanel.Padding = new Padding(offset, 0, 0, 0);

                conflictFlowPanel.AutoScroll = false;
            }
            else
            {
                conflictFlowPanel.Padding = new Padding(0);
                conflictFlowPanel.AutoScroll = true;
            }
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

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || originalBooking == null) return;

            // 1. Sync the TextBoxes back to currentPendingInfo 
            // (Dates are already synced via the ValueChanged event)
            currentPendingInfo.FirstName = firstNameTextBox.Text;
            currentPendingInfo.LastName = lastNameTextBox.Text;
            currentPendingInfo.LicenseNumber = customerLicenseTextBox.Text;
            currentPendingInfo.Email = customerEmailTextBox.Text;
            currentPendingInfo.PhoneNumber = customerContactNumTextBox.Text;
            currentPendingInfo.DateOfBirth = customerBdayDTP.Value;

            // 2. Compare currentPendingInfo vs originalBooking
            List<string> changes = new List<string>();

            if (currentPendingInfo.FirstName != originalBooking.FirstName)
                changes.Add($"• Name: {originalBooking.FirstName} → {currentPendingInfo.FirstName}");

            if (currentPendingInfo.LastName != originalBooking.LastName)
                changes.Add($"• Last Name: {originalBooking.LastName} → {currentPendingInfo.LastName}");

            if (currentPendingInfo.LicenseNumber != originalBooking.LicenseNumber)
                changes.Add($"• License: {originalBooking.LicenseNumber} → {currentPendingInfo.LicenseNumber}");

            if (currentPendingInfo.Email != originalBooking.Email)
                changes.Add($"• Email: {originalBooking.Email} → {currentPendingInfo.Email}");

            if (currentPendingInfo.PhoneNumber != originalBooking.PhoneNumber)
                changes.Add($"• Contact: {originalBooking.PhoneNumber} → {currentPendingInfo.PhoneNumber}");

            if (currentPendingInfo.DateOfBirth != originalBooking.DateOfBirth)
                changes.Add($"• DOB: {originalBooking.DateOfBirth:MMM dd, yyyy} → {currentPendingInfo.DateOfBirth:MMM dd, yyyy}");

            if (currentPendingInfo.DateSchedOut != originalBooking.DateSchedOut)
                changes.Add($"• Start: {originalBooking.DateSchedOut:MMM dd, hh:mm tt} → {currentPendingInfo.DateSchedOut:MMM dd, hh:mm tt}");

            if (currentPendingInfo.DateDue != originalBooking.DateDue)
                changes.Add($"• Return: {originalBooking.DateDue:MMM dd, hh:mm tt} → {currentPendingInfo.DateDue:MMM dd, hh:mm tt}");


            var conflicts = BookingHandler.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            string alertMessage = "Are you sure you want to approve this booking?";

            if (changes.Count > 0)
                alertMessage = "CONFIRM UPDATES:\n" + string.Join("\n", changes) + "\n\n" + alertMessage;

            if (conflicts.Count > 0)
                alertMessage = "⚠️ WARNING: There are still schedule conflicts!\n\n" + alertMessage;

            DialogResult result = MessageBox.Show(alertMessage, "Final Approval",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // ExecuteApproval();
            }


        }


        // Event listeners
        private void rentalDate_ValueChanged(object sender, EventArgs e)
        {
            // Prevent the event from firing recursively or before info is loaded
            if (currentPendingInfo == null || isSyncing) return;

            isSyncing = true; // Lock

            currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
            currentPendingInfo.DateDue = rentalDateEndDTP.Value;

            RefreshConflictSection();

            isSyncing = false; // Unlock
        }
         

    }
}
