using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ClientManagementSubsystem.userControls
{
    public partial class CompletedUserControl : UserControl
    {
        private BookingHandler db = new BookingHandler();

        // CHANGED: Use Booking type here to support the new metrics and damage flags
        private Booking currentBookingInfo;
        private Panel emptyStateOverlay;

        public event EventHandler DataChanged;

        public CompletedUserControl()
        {
            InitializeComponent();
            SetupEmptyStateOverlay();
            UpdateOverlayState();
            LockFields();
        }

        private void LockFields()
        {
            rentalDateStartDTP.Enabled = false;
            rentalDateEndDTP.Enabled = false;
            customerBdayDTP.Enabled = false;
            dateOutDTP.Enabled = false; // Actual Release
            dateInDTP.Enabled = false;  // Actual Return
        }

        #region UI States & Overlay
        private void SetupEmptyStateOverlay()
        {
            emptyStateOverlay = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            Label lblMessage = new Label
            {
                Text = "Select a completed booking to view history",
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
            if (currentBookingInfo == null)
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

        #region Public Interface
        public void DisplayBookingDetails(Booking b)
        {
            if (b == null) return;

            // Now this assignment works because types match
            currentBookingInfo = b;

            // 1. Header & Financials
            lblBookingIDValue.Text = b.BookingID.ToString();
            lblPriceValue.Text = "₱" + (b.TotalPrice ?? 0).ToString("N2");

            // 2. Usage Metrics (Out vs In)
            lblFuelLevelOutValue.Text = b.FuelLevelOut ?? "---";
            lblFuelLevelInValue.Text = b.FuelLevelIn ?? "---";
            lblMileageOutValue.Text = b.MileageOut?.ToString("N0")+"km" ?? "0";
            lblMileageInValue.Text = b.MileageIn?.ToString("N0")+"km" ?? "0";

            // 3. Customer & Vehicle Info
            firstNameTextBox.Text = b.FirstName;
            lastNameTextBox.Text = b.LastName;
            customerLicenseTextBox.Text = b.LicenseNumber;
            customerEmailTextBox.Text = b.Email;
            customerBdayDTP.Value = b.DateOfBirth;
            customerContactNumTextBox.Text = b.PhoneNumber;

            vehicleNameTextBox.Text = b.VehicleName;
            vehicleLicenseTextBox.Text = b.LicensePlate;

            // 4. Actual Dates (Replaces Scheduled logic)
            lblDateofRequestValue.Text = b.DateSubmitted.ToString("MMM dd, yyyy hh:mm tt");
            rentalDateStartDTP.Value = b.DateSchedOut;
            rentalDateEndDTP.Value = b.DateDue;
            dateOutDTP.Value = b.DateOut ?? DateTime.Now;
            dateInDTP.Value = b.DateIn ?? DateTime.Now;

            // 5. Calculate Duration from ACTUAL dates
            if (b.DateOut.HasValue && b.DateIn.HasValue)
                lblRentalTimeValue.Text = GetRentalDuration(b.DateOut.Value, b.DateIn.Value);
            else
                lblRentalTimeValue.Text = "N/A";

            // 6. Dynamic Damage Label
            if (b.HasDamage)
            {
                lblSustainedDamage.Text = "⚠️ DAMAGE DETECTED";
                lblSustainedDamage.ForeColor = Color.Red;
            }
            else
            {
                lblSustainedDamage.Text = "✅ NO DAMAGE SUSTAINED";
                lblSustainedDamage.ForeColor = Color.Green;
            }

            if (!string.IsNullOrEmpty(currentBookingInfo.FullImagePath) && System.IO.File.Exists(currentBookingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentBookingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }

        public void ClearDetails()
        {
            currentBookingInfo = null;
            lblBookingIDValue.Text = "---";
            lblPriceValue.Text = "₱0.00";
            lblSustainedDamage.Text = "---";
            lblSustainedDamage.ForeColor = Color.Gray;
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            // Clear all textboxes in the details panel
            foreach (Control c in bookingDetailsPanel.Controls)
            {
                if (c is TextBox tb) tb.Clear();
                if (c is Guna.UI2.WinForms.Guna2TextBox gtb) gtb.Clear();
            }

            UpdateOverlayState();
        }
        #endregion

        #region Helpers
        private string GetRentalDuration(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return "0 Days";
            int days = duration.Days;
            int hours = duration.Hours;
            return $"{days}d, {hours}h";
        }
        #endregion
    }
}