using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.userControls.cards; // Ensure this matches your InspectionCard namespace
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClientManagementSubsystem.userControls
{
    public partial class inboundUserControl : UserControl
    {
        private BookingServices db = new BookingServices();
        private Timer searchDebounceTimer;
        private Booking currentSelectedBooking;
        private Panel emptyStateOverlay;

        public event EventHandler DataChanged;

        public inboundUserControl()
        {
            InitializeComponent();
            SetupSearchTimer();
            SetupEmptyStateOverlay();

            bookingListPanel.Resize += (s, e) => CenterCards();
        }

        private void inboundUserControl_Load(object sender, EventArgs e)
        {
            RefreshBookingList();
            UpdateOverlayState();

            // Force scrollbar behavior
            bookingListPanel.AutoScroll = false;
            bookingListPanel.VerticalScroll.Visible = true;
            bookingListPanel.AutoScroll = true;
        }

        #region Display Logic
        public void DisplayBookingDetails(Booking b)
        {
            if (b == null) return;
            currentSelectedBooking = b;

            // Header & IDs
            lblBookingIDValue.Text = b.BookingID.ToString();
            lblDateofRequestValue.Text = b.DateSubmitted.ToString("MM/dd/yyyy hh:mm tt");

            // Customer Info
            firstNameTextBox.Text = b.FirstName;
            lastNameTextBox.Text = b.LastName;
            customerLicenseTextBox.Text = b.LicenseNumber;
            customerEmailTextBox.Text = b.Email;
            customerContactNumTextBox.Text = b.PhoneNumber;

            // Vehicle Info
            vehicleNameTextBox.Text = b.VehicleName;
            vehicleLicenseTextBox.Text = b.LicensePlate;

            // Rental Schedule & Financials
            rentalDateStartDTP.Value = b.DateSchedOut;
            rentalDateEndDTP.Value = b.DateDue;
            lblPriceValue.Text = "₱" + b.ProjectedPrice.ToString("N2");
            lblRentalTimeValue.Text = GetRentalDuration(b.DateSchedOut, b.DateDue);

            // Outbound State Info
            fuelLevelOutTextBox.Text = b.FuelLevelOut ?? "---";
            mileageOutTextBox.Text = b.MileageOut.HasValue ? b.MileageOut.Value.ToString() : "---";

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

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            customerLicenseTextBox.Clear();
            customerEmailTextBox.Clear();
            customerContactNumTextBox.Clear();
            vehicleLicenseTextBox.Clear();
            vehicleNameTextBox.Clear();
            fuelLevelOutTextBox.Text = "---";
            mileageOutTextBox.Text = "---";

            lblBookingIDValue.Text = "---";
            lblDateofRequestValue.Text = "---";
            lblPriceValue.Text = "₱0.00";
            lblRentalTimeValue.Text = "---";
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }
        #endregion

        #region Inspection Trigger (Option 1)
        private void btnStartInspection_Click(object sender, EventArgs e)
        {
            if (currentSelectedBooking == null)
            {
                MessageBox.Show("Please select a booking from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Create the Popup Form
            using (Form popup = new Form())
            {
                InspectionCard card = new InspectionCard();
                card.Populate(currentSelectedBooking);
                card.Dock = DockStyle.Fill;

                card.DataChanged += (s, args) => {
                    popup.DialogResult = DialogResult.OK;
                    popup.Close();
                };

                // 2. Fix the "Windows Tab" look & Rendering size
                // We set the FormBorderStyle to None if you want it borderless, 
                // OR FixedSingle if you want a thin modern line.
                popup.FormBorderStyle = FormBorderStyle.FixedSingle;
                popup.Text = "Vehicle Inspection Process";
                popup.ShowIcon = false;
                popup.MaximizeBox = false;
                popup.MinimizeBox = false;
                popup.StartPosition = FormStartPosition.CenterParent;

                // 3. IMPORTANT: Set the CLIENT SIZE to match your control exactly
                // This ensures the 872x650 control isn't squeezed by the window borders
                popup.ClientSize = new Size(872, 650);

                popup.Controls.Add(card);

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    RefreshBookingList();
                    ClearDetails();
                }
            }
        }
        #endregion

        #region List & Search Logic
        public void RefreshBookingList()
        {
            string term = searchBarTextBox.Text.Trim();
            const string status = "Out";

            try
            {
                List<Booking> bookings = string.IsNullOrWhiteSpace(term)
                    ? db.GetBookingsByStatus(status)
                    : db.SearchBookings(term, status);

                PopulateList(bookings);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inbound units: {ex.Message}");
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
                card.OnSelect += (s, args) => DisplayBookingDetails(((BookingCard)s).BookingData);
                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }

        private void searchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private void refreshBtn_Click(object sender, EventArgs e) => RefreshBookingList();
        private void clearSearchBarBtn_Click(object sender, EventArgs e) => searchBarTextBox.Clear();
        #endregion

        #region Helpers
        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (dob.Date > DateTime.Now.AddYears(-age)) age--;
            return age;
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
                Text = "Select a unit currently 'Out' to process return/inspection",
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
    }
}