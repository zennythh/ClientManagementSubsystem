using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientManagementSubsystem.userControls
{
    public partial class PendingUserControl : UserControl
    {
        private BookingServices db = new BookingServices();
        private Booking originalBooking;
        private PendingInfos currentPendingInfo;
        private bool isSyncing = false;
        private Panel emptyStateOverlay;

        // Parent will subscribe to this to refresh the list on the left
        public event EventHandler DataChanged;

        public PendingUserControl()
        {
            InitializeComponent();
            SetupEmptyStateOverlay();
            UpdateOverlayState();
        }

        #region Initialization & UI States
        private void SetupEmptyStateOverlay()
        {
            // Note: In the Designer, make sure bookingDetailsPanel exists here
            emptyStateOverlay = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            Label lblMessage = new Label
            {
                Text = "Select a pending booking to view details",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 20, FontStyle.Italic)
            };
            emptyStateOverlay.Controls.Add(lblMessage);
            bookingDetailsPanel.Controls.Add(emptyStateOverlay);
            emptyStateOverlay.BringToFront();
        }

        private void UpdateOverlayState()
        {
            if (currentPendingInfo == null)
            {
                emptyStateOverlay.Visible = true;
                emptyStateOverlay.BringToFront();
            }
            else
            {
                emptyStateOverlay.Visible = false;
                emptyStateOverlay.SendToBack();
            }
        }
        #endregion

        #region Public Interface (Called by Parent)
        // This is the bridge: Parent calls this when a card is clicked
        public void DisplayBookingDetails(Booking b)
        {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = MapToPendingInfo(b);

            // Fill UI Fields
            lblBookingIDValue.Text = currentPendingInfo.BookingID.ToString();
            firstNameTextBox.Text = currentPendingInfo.FirstName;
            lastNameTextBox.Text = currentPendingInfo.LastName;
            customerLicenseTextBox.Text = currentPendingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentPendingInfo.Email;
            customerContactNumTextBox.Text = currentPendingInfo.PhoneNumber;
            lblDateofRequestValue.Text = GetRequestDate(currentPendingInfo.DateSubmitted);
            vehicleLicenseTextBox.Text = currentPendingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentPendingInfo.VehicleName;

            isSyncing = true;
            rentalDateStartDTP.Value = currentPendingInfo.DateSchedOut;
            rentalDateEndDTP.Value = currentPendingInfo.DateDue;
            lblPriceValue.Text = "₱" + currentPendingInfo.ProjectedPrice.ToString("N2");
            isSyncing = false;

            lblRentalTimeValue.Text = GetRentalDuration(currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && System.IO.File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
            RefreshConflictSection();
        }
        #endregion

        #region Conflict Logic
        private void RefreshConflictSection()
        {
            if (currentPendingInfo == null) return;

            if (!IsDatePeriodValid(out _))
            {
                lblRentalTimeValue.Text = "Invalid Data";
                lblRentalTimeValue.ForeColor = Color.Red;
                lblPriceValue.Text = "₱0.00";
                conflictFlowPanel.Controls.Clear();
                lblBookingConflicts.Visible = false;
                return;
            }

            lblRentalTimeValue.ForeColor = Color.Black;
            decimal newPrice = CalculateProjectedPrice(rentalDateStartDTP.Value, rentalDateEndDTP.Value, currentPendingInfo.DailyRate);
            lblPriceValue.Text = "₱" + newPrice.ToString("N2");
            currentPendingInfo.ProjectedPrice = newPrice;
            lblRentalTimeValue.Text = GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            conflictFlowPanel.Controls.Clear();
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                rentalDateStartDTP.Value, rentalDateEndDTP.Value);

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
                    conflictFlowPanel.Controls.Add(lblNoBookingConflicts);
                lblNoBookingConflicts.Visible = true;
            }
        }
        #endregion

        #region Action Buttons
        public void approveBtn_Click(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || originalBooking == null) return;

            // FINAL DATE CHECK
            if (!IsDatePeriodValid(out string error))
            {
                MessageBox.Show($"🛑 Invalid Dates: {error}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Sync UI to currentPendingInfo
            currentPendingInfo.FirstName = firstNameTextBox.Text;
            currentPendingInfo.LastName = lastNameTextBox.Text;
            currentPendingInfo.LicenseNumber = customerLicenseTextBox.Text;
            currentPendingInfo.Email = customerEmailTextBox.Text;
            currentPendingInfo.PhoneNumber = customerContactNumTextBox.Text;
            currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
            currentPendingInfo.DateDue = rentalDateEndDTP.Value;

            // 2. Track Changes 
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

            if (currentPendingInfo.DateSchedOut != originalBooking.DateSchedOut)
                changes.Add($"• Start: {originalBooking.DateSchedOut:MMM dd, hh:mm tt} → {currentPendingInfo.DateSchedOut:MMM dd, hh:mm tt}");

            if (currentPendingInfo.DateDue != originalBooking.DateDue)
                changes.Add($"• Return: {originalBooking.DateDue:MMM dd, hh:mm tt} → {currentPendingInfo.DateDue:MMM dd, hh:mm tt}");

            // 3. Fetch Conflicts
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            // 4. CATEGORIZE CONFLICTS
            var (hardDirectConflicts, bufferOverlapsWithActive, pendingConflicts) =
                ClassifyConflicts(currentPendingInfo, conflicts);

            // --- EXECUTE HARD BLOCK ---
            if (hardDirectConflicts.Any())
            {
                MessageBox.Show("🛑 CANNOT APPROVE: This vehicle is already 'Reserved' or 'Out' during this exact timeframe. You must resolve the existing booking first.",
                                "Hard Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 5. BUILD THE ALERT MESSAGE
            string alertMessage = "Are you sure you want to approve this booking?";

            // Add changes to message
            if (changes.Count > 0)
                alertMessage = "CONFIRM UPDATES:\n" + string.Join("\n", changes) + "\n\n" + alertMessage;

            // Add Buffer/Pending warnings
            string warnings = "";

            if (pendingConflicts.Count > 0)
                warnings += $"⚠️ WARNING: This will automatically REJECT {pendingConflicts.Count} other PENDING request(s).\n";

            if (bufferOverlapsWithActive.Any())
                warnings += "⏳ BUFFER NOTICE: This cuts into the 3-hour cleanup window of an existing reservation. Ensure staff has time to prep the car!\n";

            if (!string.IsNullOrEmpty(warnings))
                alertMessage = warnings + "\n" + alertMessage;

            // 6. FINAL CONFIRMATION
            DialogResult result = MessageBox.Show(alertMessage, "Final Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var dbResult = db.ProcessApproval(currentPendingInfo);
                if (dbResult.success)
                {
                    MessageBox.Show(dbResult.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDetails();
                    DataChanged?.Invoke(this, EventArgs.Empty); // Tell parent to refresh list
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void rejectBtn_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure a booking is actually selected
            if (currentPendingInfo == null) return;

            // 2. Confirmation: Ask the user to be sure
            string msg = $"Are you sure you want to REJECT the booking for {currentPendingInfo.FirstName} {currentPendingInfo.LastName}?\n\nThis action cannot be undone.";
            DialogResult result = MessageBox.Show(msg, "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 3. Execute: Call the DB handler
                var dbResult = db.ProcessRejection(currentPendingInfo.BookingID);

                if (dbResult.success)
                {
                    MessageBox.Show(dbResult.message, "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Cleanup: Clear the details and notify parent
                    ClearDetails();
                    DataChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Helpers (Map, Calculate, Center)
        public void ClearDetails()
        {
            currentPendingInfo = null;
            originalBooking = null;

            // This is safer than a loop which might hit the overlay
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            customerLicenseTextBox.Clear();
            customerEmailTextBox.Clear();
            customerContactNumTextBox.Clear();
            vehicleLicenseTextBox.Clear();
            vehicleNameTextBox.Clear();

            lblBookingIDValue.Text = "---";
            conflictFlowPanel.Controls.Clear();
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }

        private PendingInfos MapToPendingInfo(Booking b)
        {
            return new PendingInfos
            {
                BookingID = b.BookingID,
                FirstName = b.FirstName,
                LastName = b.LastName,
                LicenseNumber = b.LicenseNumber,
                Email = b.Email,
                PhoneNumber = b.PhoneNumber,
                VehicleVIN = b.VehicleVIN,
                VehicleName = b.VehicleName,
                LicensePlate = b.LicensePlate,
                ImagePath = b.ImagePath,
                DateSchedOut = b.DateSchedOut,
                DateDue = b.DateDue,
                DateSubmitted = b.DateSubmitted,
                DailyRate = b.DailyRate,
                ProjectedPrice = b.ProjectedPrice
            };
        }

        private (List<Booking> HardDirect, List<Booking> BufferOverlaps, List<Booking> Pending) ClassifyConflicts(PendingInfos pending, List<Booking> conflicts)
        {
            var hardDirect = conflicts.Where(c => (c.Status == "Reserved" || c.Status == "Out") && pending.DateSchedOut < c.DateDue).ToList();
            var bufferOverlaps = conflicts.Where(c => pending.DateSchedOut >= c.DateDue && pending.DateSchedOut <= c.DateDue.AddHours(3)).ToList();
            var pendingList = conflicts.Where(c => c.Status == "Pending").ToList();
            return (hardDirect, bufferOverlaps, pendingList);
        }

        private string GetRequestDate(DateTime date)
        {
            DateTime now = DateTime.Now;
            if (date.Date == now.Date) return $"Today at {date:hh:mm tt}";
            if (date.Date == now.AddDays(-1).Date) return $"Yesterday at {date:hh:mm tt}";
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

        private bool IsDatePeriodValid(out string errorMessage)
        {
            errorMessage = string.Empty;
            if (rentalDateEndDTP.Value <= rentalDateStartDTP.Value)
            {
                errorMessage = "Return date must be after the pickup date.";
                return false;
            }
            return true;
        }

        private decimal CalculateProjectedPrice(DateTime start, DateTime end, decimal dailyRate)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return 0;
            int totalDays = (int)Math.Ceiling(duration.TotalHours / 24.0);
            return totalDays * dailyRate;
        }

        private void CenterConflictCards()
        {
            int totalCardsWidth = 0;
            foreach (Control card in conflictFlowPanel.Controls)
                totalCardsWidth += card.Width + card.Margin.Horizontal;

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
        #endregion

        #region Event Handlers for Date Changes (to refresh conflicts)
        public void rentalDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || isSyncing) return;

            try
            {
                isSyncing = true;
                currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
                currentPendingInfo.DateDue = rentalDateEndDTP.Value;

                RefreshConflictSection();
            }
            finally
            {
                isSyncing = false; // This ALWAYS runs, even if RefreshConflictSection crashes
            }
        }
        #endregion
    }
}