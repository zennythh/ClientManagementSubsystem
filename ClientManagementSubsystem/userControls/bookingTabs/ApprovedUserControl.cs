using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientManagementSubsystem.userControls
{
    public partial class ApprovedUserControl : UserControl
    {
        private BookingHandler db = new BookingHandler();
        private PendingInfos currentBookingInfo;
        private Panel emptyStateOverlay;

        public event EventHandler DataChanged;

        public ApprovedUserControl()
        {
            InitializeComponent();
            SetupEmptyStateOverlay();
            UpdateOverlayState();
        }

        #region UI States & Overlay
        private void SetupEmptyStateOverlay()
        {
            emptyStateOverlay = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            Label lblMessage = new Label
            {
                Text = "Select a reserved booking to view details",
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

            currentBookingInfo = MapToInfo(b);

            // Fill UI Fields (Read-only for Approved bookings usually)
            lblBookingIDValue.Text = currentBookingInfo.BookingID.ToString();
            firstNameTextBox.Text = currentBookingInfo.FirstName;
            lastNameTextBox.Text = currentBookingInfo.LastName;
            customerLicenseTextBox.Text = currentBookingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentBookingInfo.Email;
            customerContactNumTextBox.Text = currentBookingInfo.PhoneNumber;
            customerBdayDTP.Value = currentBookingInfo.DateOfBirth;
            customerAgeTextBox.Text = currentBookingInfo.Age.ToString();
            lblDateofRequestValue.Text = GetFormattedDate(currentBookingInfo.DateSubmitted);
            vehicleLicenseTextBox.Text = currentBookingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentBookingInfo.VehicleName;

            rentalDateStartDTP.Value = currentBookingInfo.DateSchedOut;
            rentalDateEndDTP.Value = currentBookingInfo.DateDue;
            lblPriceValue.Text = "₱" + currentBookingInfo.ProjectedPrice.ToString("N2");
            lblRentalTimeValue.Text = GetRentalDuration(currentBookingInfo.DateSchedOut, currentBookingInfo.DateDue);

            if (!string.IsNullOrEmpty(currentBookingInfo.FullImagePath) && System.IO.File.Exists(currentBookingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentBookingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }

        public void ClearDetails()
        {
            currentBookingInfo = null;

            // Clear all textboxes/labels
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            customerLicenseTextBox.Clear();
            customerEmailTextBox.Clear();
            customerContactNumTextBox.Clear();
            customerAgeTextBox.Clear();
            vehicleLicenseTextBox.Clear();
            vehicleNameTextBox.Clear();
            lblBookingIDValue.Text = "---";
            vehiclePictureBox.Image = Properties.Resources.defaultVehicle;

            UpdateOverlayState();
        }
        #endregion

        #region Action Buttons
        public void rejectBtn_Click(object sender, EventArgs e)
        {
            if (currentBookingInfo == null) return;

            string msg = $"Are you sure you want to CANCEL the reservation for {currentBookingInfo.FirstName} {currentBookingInfo.LastName}?\n\nThis will return the vehicle to the available pool.";
            DialogResult result = MessageBox.Show(msg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // We use the same ProcessRejection logic as it updates status to 'Rejected'
                var dbResult = db.ProcessRejection(currentBookingInfo.BookingID);

                if (dbResult.success)
                {
                    MessageBox.Show("Reservation successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Helpers
        private PendingInfos MapToInfo(Booking b)
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
            return (days > 0 && hours > 0) ? $"{dayPart}, {hourPart}" : (string.IsNullOrEmpty(dayPart) ? hourPart : dayPart);
        }
        #endregion
    }
}