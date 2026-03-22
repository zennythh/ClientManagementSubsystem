using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ClientManagementSubsystem.userControls
{
    public partial class outboundUserControl : UserControl
    {
        private BookingHandler db = new BookingHandler();
        private Timer searchDebounceTimer;
        private Booking currentSelectedBooking; // Using Booking directly to avoid conversion issues
        private Panel emptyStateOverlay;

        public outboundUserControl()
        {
            InitializeComponent();
            SetupSearchTimer();
            SetupEmptyStateOverlay();

            bookingListPanel.Resize += (s, e) => CenterCards();
        }

        // Add this line inside the class
        public event EventHandler DataChanged;

        private void outboundUserControl_Load(object sender, EventArgs e)
        {
            RefreshBookingList();
            UpdateOverlayState();

            // Force scrollbar behavior
            bookingListPanel.AutoScroll = false;
            bookingListPanel.VerticalScroll.Visible = true;
            bookingListPanel.AutoScroll = true;
        }

        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (dob.Date > DateTime.Now.AddYears(-age)) age--;
            return age;
        }

        #region Public Interface (Display Logic)
        public void DisplayBookingDetails(Booking b)
        {
            if (b == null) return;
            currentSelectedBooking = b;

            // Header & IDs
            lblBookingIDValue.Text = b.BookingID.ToString();
            lblDateofRequestValue.Text = GetFormattedDate(b.DateSubmitted);

            // Customer Info
            firstNameTextBox.Text = b.FirstName;
            lastNameTextBox.Text = b.LastName;
            customerLicenseTextBox.Text = b.LicenseNumber;
            customerEmailTextBox.Text = b.Email;
            customerContactNumTextBox.Text = b.PhoneNumber;
            customerBdayDTP.Value = b.DateOfBirth;
            customerAgeTextBox.Text = CalculateAge(b.DateOfBirth).ToString();
            // Vehicle Info
            vehicleNameTextBox.Text = b.VehicleName;
            vehicleLicenseTextBox.Text = b.LicensePlate;

            // Rental Schedule & Financials
            rentalDateStartDTP.Value = b.DateSchedOut;
            rentalDateEndDTP.Value = b.DateDue;
            lblPriceValue.Text = "₱" + b.ProjectedPrice.ToString("N2");
            lblRentalTimeValue.Text = GetRentalDuration(b.DateSchedOut, b.DateDue);

            // Image Loading
            if (!string.IsNullOrEmpty(b.FullImagePath) && System.IO.File.Exists(b.FullImagePath))
                vehiclePictureBox.ImageLocation = b.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }

        public void ClearDetails()
        {
            currentSelectedBooking = null;

            // Clear all textboxes
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            customerLicenseTextBox.Clear();
            customerEmailTextBox.Clear();
            customerContactNumTextBox.Clear();
            customerAgeTextBox.Clear();
            vehicleLicenseTextBox.Clear();
            vehicleNameTextBox.Clear();

            // Reset Labels
            lblBookingIDValue.Text = "---";
            lblDateofRequestValue.Text = "---";
            lblPriceValue.Text = "₱0.00";
            lblRentalTimeValue.Text = "---";
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }
        #endregion

        #region List & Search Logic
        public void RefreshBookingList()
        {
            string term = searchBarTextBox.Text.Trim();
            const string status = "Reserved";

            try
            {
                List<Booking> bookings = string.IsNullOrWhiteSpace(term)
                    ? db.GetBookingsByStatus(status)
                    : db.SearchBookings(term, status);

                PopulateList(bookings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading outbound units: {ex.Message}");
            }
        }

        private void PopulateList(List<Booking> bookings)
        {
            bookingListPanel.SuspendLayout();
            bookingListPanel.Controls.Clear();

            if (bookings == null || bookings.Count == 0)
            {
                ClearDetails();
                bookingListPanel.ResumeLayout();
                CenterCards();
                return;
            }

            foreach (var b in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(b);
                card.OnSelect += (s, e) => DisplayBookingDetails(((BookingCard)s).BookingData);
                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }
        #endregion

        #region Helpers (Extracted)
        private string GetFormattedDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy hh:mm tt");
        }

        private string GetRentalDuration(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return "Invalid Dates";
            int days = duration.Days;
            int hours = duration.Hours;

            string dayPart = days > 0 ? $"{days} {(days == 1 ? "Day" : "Days")}" : "";
            string hourPart = hours > 0 ? $"{hours} {(hours == 1 ? "Hour" : "Hrs")}" : "";

            if (days > 0 && hours > 0) return $"{dayPart}, {hourPart}";
            return string.IsNullOrEmpty(dayPart) ? hourPart : dayPart;
        }

        private void CenterCards()
        {
            if (bookingListPanel.Controls.Count == 0) return;
            int usableWidth = bookingListPanel.ClientSize.Width - (bookingListPanel.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0);

            foreach (Control c in bookingListPanel.Controls)
            {
                int margin = (usableWidth - c.Width) / 2;
                c.Margin = new Padding(Math.Max(0, margin), c.Margin.Top, 0, c.Margin.Bottom);
            }
        }

        private void SetupSearchTimer()
        {
            searchDebounceTimer = new Timer { Interval = 350 };
            searchDebounceTimer.Tick += (s, e) => { searchDebounceTimer.Stop(); RefreshBookingList(); };
        }

        private void SetupEmptyStateOverlay()
        {
            emptyStateOverlay = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            Label lbl = new Label
            {
                Text = "Select a reserved booking to begin unit release",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 14, FontStyle.Italic)
            };
            emptyStateOverlay.Controls.Add(lbl);
            bookingDetailsPanel.Controls.Add(emptyStateOverlay);
        }

        private void UpdateOverlayState()
        {
            if (emptyStateOverlay == null) return;
            emptyStateOverlay.Visible = (currentSelectedBooking == null);
            if (emptyStateOverlay.Visible) emptyStateOverlay.BringToFront();
        }
        #endregion

        #region Event Handlers
        private void searchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private void customerBdayDTP_ValueChanged(object sender, EventArgs e)
        {
            customerAgeTextBox.Text = CalculateAge(customerBdayDTP.Value).ToString();
        }

        private void mileageOutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and the backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // This blocks the input
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e) => RefreshBookingList();
        private void clearSearchBarBtn_Click(object sender, EventArgs e) => searchBarTextBox.Clear();
        #endregion

        private void releaseBtn_Click(object sender, EventArgs e)
        {
            // 1. Basic Selection Check
            if (currentSelectedBooking == null)
            {
                MessageBox.Show("Please select a reserved booking first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Validation: Mileage
            if (!int.TryParse(mileageOutTextBox.Text, out int mOut) || mOut <= 0)
            {
                MessageBox.Show("Please enter a valid starting mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mileageOutTextBox.Focus();
                return;
            }

            // 3. Validation: Fuel Level
            string fOut = fuelLevelOutTextBox.Text.Trim();
            if (string.IsNullOrEmpty(fOut))
            {
                MessageBox.Show("Please indicate the starting fuel level (e.g., Full, 75%, etc.).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fuelLevelOutTextBox.Focus();
                return;
            }

            if (currentSelectedBooking.DateSchedOut.Date != DateTime.Today)
            {
                string dateWarn = $"⚠️ DATE MISMATCH:\n\n" +
                                  $"This booking is scheduled for: {currentSelectedBooking.DateSchedOut:MMM dd, yyyy}\n" +
                                  $"Today's Date: {DateTime.Today:MMM dd, yyyy}\n\n" +
                                  "Are you sure you want to release this unit early/late?";

                DialogResult dateResult = MessageBox.Show(dateWarn, "Schedule Warning",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dateResult == DialogResult.No) return;
            }

            // 4. Confirmation
            string msg = $"Release vehicle {currentSelectedBooking.LicensePlate} to {currentSelectedBooking.FirstName}?\n" +
                         $"Starting Mileage: {mOut} km\n" +
                         $"Fuel Level: {fOut}";

            if (MessageBox.Show(msg, "Confirm Release", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = db.ProcessUnitRelease(
                    currentSelectedBooking.BookingID,
                    currentSelectedBooking.VehicleVIN,
                    mOut,
                    fOut
                );

                if (result.success)
                {
                    MessageBox.Show(result.message, "Unit Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDetails(); // Clear UI
                    DataChanged?.Invoke(this, EventArgs.Empty); // Refresh parent list
                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // 1. Check if a booking is actually selected
            if (currentSelectedBooking == null)
            {
                MessageBox.Show("Please select a booking to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Double Confirmation
            string msg = $"Are you sure you want to cancel the booking for {currentSelectedBooking.FirstName} {currentSelectedBooking.LastName}?\n\n" +
                         "This will mark the status as 'Rejected'.";

            if (MessageBox.Show(msg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // 3. Reuse your existing ProcessRejection method
                var result = db.ProcessRejection(currentSelectedBooking.BookingID);

                if (result.success)
                {
                    MessageBox.Show("Booking has been successfully cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDetails(); // Reset the UI fields
                    DataChanged?.Invoke(this, EventArgs.Empty); // Trigger refresh on the parent list
                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}