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
        private Panel emptyStateOverlay;
        // Add this at the top of your class variables
        private Timer searchDebounceTimer;

        public bookingsUserControl()
        {
            InitializeComponent();

            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350; // 350 milliseconds cooldown
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
            LoadBookingCards();
            // LoadBookings(); for noDB test purposes

            // Create the overlay panel
            emptyStateOverlay = new Panel();
            emptyStateOverlay.Dock = DockStyle.Fill;
            emptyStateOverlay.BackColor = Color.White; // Or matches your UI background

            // Add a nice message label in the center
            Label lblMessage = new Label();
            lblMessage.Text = "Select a booking from the list to view details";
            lblMessage.AutoSize = false;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.ForeColor = Color.Gray;
            lblMessage.Font = new Font("Segoe UI", 24, FontStyle.Italic);

            emptyStateOverlay.Controls.Add(lblMessage);

            // Add it to the bookingDetailsPanel and bring it to front
            bookingDetailsPanel.Controls.Add(emptyStateOverlay);
            emptyStateOverlay.BringToFront();

            LoadBookingCards();
            UpdateOverlayState(); // Set initial state
        }

        private void SearchDebounceTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer so it doesn't keep firing
            searchDebounceTimer.Stop();

            string term = searchBarTextBox.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                LoadBookingCards();
                return;
            }

            // Run the search logic
            var filteredResults = db.SearchBookings(term, "Pending");
            PopulateBookingList(filteredResults);
        }


        // Render functions
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
                        UpdateOverlayState(); 
                    };

                    bookingListPanel.Controls.Add(card);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            CenterCards();
        }

        // Change the signature to accept a list (optional)
        private void PopulateBookingList(List<Booking> bookings)
        {
            bookingListPanel.Controls.Clear();

            foreach (Booking booking in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(booking);
                    
                // IMPORTANT: Ensure the vehicle name is passed to the card UI
                card.VehicleName = booking.VehicleName;

                card.OnSelect += (s, e) => {
                    BookingCard clickedCard = (BookingCard)s;
                    originalBooking = clickedCard.BookingData;
                    currentPendingInfo = MapToPendingInfo(originalBooking);
                    DisplayBookingDetails(currentPendingInfo);
                    UpdateOverlayState();
                };

                bookingListPanel.Controls.Add(card);
            }
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

        private void DisplayBookingDetails(PendingInfos b)
        {
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
            lblPriceValue.Text = "₱" + b.ProjectedPrice.ToString("N2");
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

        // Local helpers
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
                DateSubmitted = b.DateSubmitted,
                DailyRate = b.DailyRate,
                ProjectedPrice = b.ProjectedPrice
            };
        }
        private (List<Booking> HardDirect, List<Booking> BufferOverlaps, List<Booking> Pending) ClassifyConflicts(PendingInfos pending, List<Booking> conflicts)
        {
            // Hard Block: requested start is BEFORE an active/reserved booking's return -> direct overlap
            var hardDirect = conflicts
                .Where(c => (c.Status == "Reserved" || c.Status == "Out") && pending.DateSchedOut < c.DateDue)
                .ToList();

            // Buffer Overlap: requested start falls within the 3-hour buffer after some booking's DateDue.
            // We detect buffer overlaps for any status (Pending / Reserved / Out) so the user is warned even if it will be auto-rejected.
            var bufferOverlaps = conflicts
                .Where(c => pending.DateSchedOut >= c.DateDue
                            && pending.DateSchedOut <= c.DateDue.AddHours(3))
                .ToList();

            // Pending requests (used for auto-reject count)
            var pendingList = conflicts.Where(c => c.Status == "Pending").ToList();

            return (hardDirect, bufferOverlaps, pendingList);
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
                return "Invalid Dates";
            }

            int days = duration.Days;
            int hours = duration.Hours;

            string dayPart = days > 0 ? $"{days} {(days == 1 ? "Day" : "Days")}" : "";
            string hourPart = hours > 0 ? $"{hours} {(hours == 1 ? "Hour" : "Hrs")}" : "";

            if (days > 0 && hours > 0) return $"{dayPart}, {hourPart}";
            lblRentalTimeValue.ForeColor = Color.Black;
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

            // Optional: Prevent bookings in the past (if you want to enforce this)
            //if (rentalDateStartDTP.Value < DateTime.Now.AddMinutes(-15)) // 15-min grace period
            //{
            //    errorMessage = "Pickup date cannot be in the past.";
            //    return false;
            //}


            return true;
        }

        private void RefreshConflictSection()
        {
            if (currentPendingInfo == null) return;

            // 1. Run Validation
            bool isValid = IsDatePeriodValid(out string error);

            if (!isValid)
            {
                // UI Feedback for Error State
                lblRentalTimeValue.Text = "Invalid Data";
                lblRentalTimeValue.ForeColor = Color.Red;
                lblPriceValue.Text = "₱0.00";
                currentPendingInfo.ProjectedPrice = 0;

                conflictFlowPanel.Controls.Clear();
                lblBookingConflicts.Visible = false;
                return; // Exit early
            }

            // 2. UI Reset for Success State
            lblRentalTimeValue.ForeColor = Color.Black;

            // 3. Logic & Calculation
            decimal newPrice = CalculateProjectedPrice(rentalDateStartDTP.Value, rentalDateEndDTP.Value, currentPendingInfo.DailyRate);
            lblPriceValue.Text = "₱" + newPrice.ToString("N2");
            currentPendingInfo.ProjectedPrice = newPrice;

            // Use the duration helper
            lblRentalTimeValue.Text = GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            // 4. Conflict Checking (Existing Logic)
            conflictFlowPanel.Controls.Clear();
            var conflicts = BookingHandler.GetConflictingBookings(
                                currentPendingInfo.BookingID,
                                currentPendingInfo.VehicleVIN,
                                rentalDateStartDTP.Value,
                                rentalDateEndDTP.Value);

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

        private void ClearDetails()
        {
            currentPendingInfo = null;
            originalBooking = null;

            // Clear textboxes (loop through your details container)
            foreach (Control c in bookingDetailsPanel.Controls) // Replace with your actual container name
            {
                if (c is TextBox tb) tb.Clear();
            }

            lblBookingIDValue.Text = "---";
            conflictFlowPanel.Controls.Clear();
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }

        private decimal CalculateProjectedPrice(DateTime start, DateTime end, decimal dailyRate)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return 0;

            // Round up to the nearest full day (e.g., 25 hours = 2 days)
            int totalDays = (int)Math.Ceiling(duration.TotalHours / 24.0);
            return totalDays * dailyRate;
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
            currentPendingInfo.DateOfBirth = customerBdayDTP.Value;

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

            if (currentPendingInfo.DateOfBirth != originalBooking.DateOfBirth)
                changes.Add($"• DOB: {originalBooking.DateOfBirth:MMM dd, yyyy} → {currentPendingInfo.DateOfBirth:MMM dd, yyyy}");

            if (currentPendingInfo.DateSchedOut != originalBooking.DateSchedOut)
                changes.Add($"• Start: {originalBooking.DateSchedOut:MMM dd, hh:mm tt} → {currentPendingInfo.DateSchedOut:MMM dd, hh:mm tt}");

            if (currentPendingInfo.DateDue != originalBooking.DateDue)
                changes.Add($"• Return: {originalBooking.DateDue:MMM dd, hh:mm tt} → {currentPendingInfo.DateDue:MMM dd, hh:mm tt}");

            // 3. Fetch Conflicts
            var conflicts = BookingHandler.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            // 4. CATEGORIZE CONFLICTS (now delegated to helper)
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

            // pendingConflicts are still used to indicate how many will be auto-rejected
            if (pendingConflicts.Count > 0)
                warnings += $"⚠️ WARNING: This will automatically REJECT {pendingConflicts.Count} other PENDING request(s).\n";

            // Show buffer notice if ANY conflict falls within the 3-hour buffer window (regardless of status)
            if (bufferOverlapsWithActive.Any())
                warnings += "⏳ BUFFER NOTICE: This cuts into the 3-hour cleanup window of an existing reservSation. Ensure staff has time to prep the car!\n";
            else if (bufferOverlapsWithActive.Count == 0 && bufferOverlapsWithActive != null)
            {
                // In case buffer overlaps list includes pending items (when the helper returned buffer overlaps),
                // check the generic buffer list (rename or keep a reference depending on your ClassifyConflicts return usage).
                // If using the helper as provided above, the variable from the tuple is named bufferOverlapsWithActive;
                // it now contains ANY buffer overlap regardless of status, so the single check above covers both cases.
            }

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
                    LoadBookingCards();
                    ClearDetails();
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event listeners
        private void rentalDate_ValueChanged(object sender, EventArgs e)
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

        private void searchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            // Stop the timer if it's already running (user is still typing)
            searchDebounceTimer.Stop();

            // Start/Restart the timer
            searchDebounceTimer.Start();
        }

        private void rejectBtn_Click(object sender, EventArgs e)
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

                    // 4. Cleanup: Refresh the list and clear the details panel
                    LoadBookingCards();
                    ClearDetails();
                }
                else
                {
                    MessageBox.Show(dbResult.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
