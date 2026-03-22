using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;

namespace ClientManagementSubsystem.userControls.cards
{
    public partial class InspectionCard : UserControl
    {
        private BookingHandler db = new BookingHandler();
        private Booking currentSelectedBooking;
        private List<string> selectedPaths = new List<string>();

        public event EventHandler DataChanged;

        public InspectionCard()
        {
            InitializeComponent();
            SetupFeeCalculation();
        }

        /// <summary>
        /// Called by InboundUserControl to pass the selected booking data.
        /// </summary>
        public void Populate(Booking b)
        {
            if (b == null) return;

            ClearDetails();
            currentSelectedBooking = b;

            // Map the "Out" state data retrieved from the database
            fuelLevelOutTextBox.Text = b.FuelLevelOut;
            mileageOutTextBox.Text = b.MileageOut.ToString();

            // Initial price display
            UpdateTotalDisplay();
        }

        #region Calculation Logic
        private void SetupFeeCalculation()
        {
            // Update total price automatically when fees are typed
            additionalFeesTextBox.TextChanged += (s, e) => UpdateTotalDisplay();
        }

        private void UpdateTotalDisplay()
        {
            if (currentSelectedBooking == null) return;

            decimal basePrice = (decimal)currentSelectedBooking.ProjectedPrice;
            decimal additionalFees = 0;

            if (decimal.TryParse(additionalFeesTextBox.Text, out decimal fees))
            {
                additionalFees = fees;
            }

            lblTotalPriceValue.Text = "₱" + (basePrice + additionalFees).ToString("N2");
        }
        #endregion

        #region Image Handling
        private void btnUploadImages_Click(object sender, EventArgs e) => TriggerImageUpload();

        private bool TriggerImageUpload()
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Multiselect = true, Filter = "Images|*.jpg;*.png;*.jpeg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in ofd.FileNames)
                    {
                        if (!selectedPaths.Contains(path))
                        {
                            selectedPaths.Add(path);
                            AddThumbnail(path);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private void AddThumbnail(string path)
        {
            PictureBox pic = new PictureBox
            {
                Size = new Size(100, 80),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(path),
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle
            };

            pic.DoubleClick += (s, e) => {
                flpThumbnails.Controls.Remove(pic);
                selectedPaths.Remove(path);
                pic.Dispose();
            };

            flpThumbnails.Controls.Add(pic);
        }
        #endregion

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (currentSelectedBooking == null) return;

            // 1. Hard Requirement for Images
            if (selectedPaths.Count == 0)
            {
                MessageBox.Show("At least one inspection image is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!TriggerImageUpload()) return;
            }

            if (MessageBox.Show("Finalize inspection and save images?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // List to hold the relative paths for the database
                    List<string> relativePathsForDb = new List<string>();

                    // 2. Define the base storage directory
                    string baseFolder = Path.Combine(RoamingPath.roamingBase, "CarRentalApp", "Images", "Inspections");

                    // Ensure the directory exists physically
                    if (!Directory.Exists(baseFolder))
                    {
                        Directory.CreateDirectory(baseFolder);
                    }

                    // 3. Process each selected image
                    foreach (string tempPath in selectedPaths)
                    {
                        // Generate a unique filename to prevent overwriting
                        string extension = Path.GetExtension(tempPath);
                        string fileName = $"insp_{currentSelectedBooking.BookingID}_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 4)}{extension}";

                        // Full path for the File.Copy operation
                        string destinationPath = Path.Combine(baseFolder, fileName);

                        // Relative path for the Database (Starting with Images\Inspections)
                        string dbPath = Path.Combine("Images", "Inspections", fileName);

                        // Copy the file from the user's computer to the Roaming folder
                        File.Copy(tempPath, destinationPath, true);

                        // Add to our list for the DB insert
                        relativePathsForDb.Add(dbPath);
                    }

                    // 4. Save to Database
                    // Note: Update your BookingHandler to accept this list of relative paths
                    bool success = db.SaveFullInspection(
                        currentSelectedBooking.BookingID,
                        currentSelectedBooking.VehicleVIN,
                        inspectionNotesTextBox.Text.Trim(),
                        damageReportTextBox.Text.Trim(),
                        relativePathsForDb // This list now contains strings like "Images\Inspections\file.jpg"
                    );

                    if (success)
                    {
                        MessageBox.Show("Inspection data and images saved successfully!", "Success");
                        ClearDetails();
                        DataChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File error: {ex.Message}", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearDetails()
        {
            currentSelectedBooking = null;
            fuelLevelOutTextBox.Clear();
            mileageOutTextBox.Clear();
            additionalFeesTextBox.Clear();
            inspectionNotesTextBox.Clear();
            damageReportTextBox.Clear();
            lblTotalPriceValue.Text = "₱0.00";
            selectedPaths.Clear();
            flpThumbnails.Controls.Clear();
        }
    }
}