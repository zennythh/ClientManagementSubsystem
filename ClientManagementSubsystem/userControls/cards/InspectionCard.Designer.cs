namespace ClientManagementSubsystem.userControls.cards
{
    partial class InspectionCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.finalizeBtn = new FontAwesome.Sharp.IconButton();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.additionalFeesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAdditionalFees = new System.Windows.Forms.Label();
            this.btnUploadImages = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblImageUploads = new System.Windows.Forms.Label();
            this.flpThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.damageReportTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDamageReport = new System.Windows.Forms.Label();
            this.inspectionNotesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInspectionNotes = new System.Windows.Forms.Label();
            this.lblUsageMetrics = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.mileageOutTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fuelLevelOutTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMileageOut = new System.Windows.Forms.Label();
            this.lblFuelLevelOut = new System.Windows.Forms.Label();
            this.lblKmIn = new System.Windows.Forms.Label();
            this.mileageInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fuelLevelInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMileageIn = new System.Windows.Forms.Label();
            this.lblFuelLevelIn = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerPanel
            // 
            this.outerPanel.BackColor = System.Drawing.Color.Transparent;
            this.outerPanel.BorderColor = System.Drawing.Color.Black;
            this.outerPanel.BorderRadius = 20;
            this.outerPanel.BorderThickness = 2;
            this.outerPanel.Controls.Add(this.finalizeBtn);
            this.outerPanel.Controls.Add(this.lblNote2);
            this.outerPanel.Controls.Add(this.lblTotalPriceValue);
            this.outerPanel.Controls.Add(this.lblTotalPrice);
            this.outerPanel.Controls.Add(this.lblPeso);
            this.outerPanel.Controls.Add(this.additionalFeesTextBox);
            this.outerPanel.Controls.Add(this.lblAdditionalFees);
            this.outerPanel.Controls.Add(this.btnUploadImages);
            this.outerPanel.Controls.Add(this.lblImageUploads);
            this.outerPanel.Controls.Add(this.flpThumbnails);
            this.outerPanel.Controls.Add(this.lblNote1);
            this.outerPanel.Controls.Add(this.damageReportTextBox);
            this.outerPanel.Controls.Add(this.lblDamageReport);
            this.outerPanel.Controls.Add(this.inspectionNotesTextBox);
            this.outerPanel.Controls.Add(this.lblInspectionNotes);
            this.outerPanel.Controls.Add(this.lblUsageMetrics);
            this.outerPanel.Controls.Add(this.lblKm);
            this.outerPanel.Controls.Add(this.mileageOutTextBox);
            this.outerPanel.Controls.Add(this.fuelLevelOutTextBox);
            this.outerPanel.Controls.Add(this.lblMileageOut);
            this.outerPanel.Controls.Add(this.lblFuelLevelOut);
            this.outerPanel.Controls.Add(this.lblKmIn);
            this.outerPanel.Controls.Add(this.mileageInTextBox);
            this.outerPanel.Controls.Add(this.fuelLevelInTextBox);
            this.outerPanel.Controls.Add(this.lblMileageIn);
            this.outerPanel.Controls.Add(this.lblFuelLevelIn);
            this.outerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerPanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.outerPanel.Location = new System.Drawing.Point(0, 0);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(872, 650);
            this.outerPanel.TabIndex = 0;
            // 
            // finalizeBtn
            // 
            this.finalizeBtn.BackColor = System.Drawing.Color.LightGreen;
            this.finalizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizeBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizeBtn.ForeColor = System.Drawing.Color.Black;
            this.finalizeBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.finalizeBtn.IconColor = System.Drawing.Color.Black;
            this.finalizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.finalizeBtn.Location = new System.Drawing.Point(455, 540);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Size = new System.Drawing.Size(346, 78);
            this.finalizeBtn.TabIndex = 86;
            this.finalizeBtn.Text = "Finalize Transaction";
            this.finalizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.finalizeBtn.UseVisualStyleBackColor = false;
            this.finalizeBtn.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.BackColor = System.Drawing.Color.Transparent;
            this.lblNote2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.Location = new System.Drawing.Point(21, 622);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(283, 20);
            this.lblNote2.TabIndex = 85;
            this.lblNote2.Text = "* Leave blank if there are no additional fees";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(297, 583);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(92, 30);
            this.lblTotalPriceValue.TabIndex = 84;
            this.lblTotalPriceValue.Text = "₱ 23000";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(185, 583);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(121, 30);
            this.lblTotalPrice.TabIndex = 83;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(21, 575);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(36, 40);
            this.lblPeso.TabIndex = 82;
            this.lblPeso.Text = "₱";
            // 
            // additionalFeesTextBox
            // 
            this.additionalFeesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.additionalFeesTextBox.DefaultText = "21312";
            this.additionalFeesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.additionalFeesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.additionalFeesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.additionalFeesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.additionalFeesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.additionalFeesTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalFeesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.additionalFeesTextBox.Location = new System.Drawing.Point(55, 575);
            this.additionalFeesTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.additionalFeesTextBox.Multiline = true;
            this.additionalFeesTextBox.Name = "additionalFeesTextBox";
            this.additionalFeesTextBox.PlaceholderText = "";
            this.additionalFeesTextBox.SelectedText = "";
            this.additionalFeesTextBox.Size = new System.Drawing.Size(121, 43);
            this.additionalFeesTextBox.TabIndex = 81;
            // 
            // lblAdditionalFees
            // 
            this.lblAdditionalFees.AutoSize = true;
            this.lblAdditionalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblAdditionalFees.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalFees.Location = new System.Drawing.Point(29, 528);
            this.lblAdditionalFees.Name = "lblAdditionalFees";
            this.lblAdditionalFees.Size = new System.Drawing.Size(214, 37);
            this.lblAdditionalFees.TabIndex = 80;
            this.lblAdditionalFees.Text = "Additional Fees";
            // 
            // btnUploadImages
            // 
            this.btnUploadImages.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.Image = global::ClientManagementSubsystem.Properties.Resources.file_up__1_;
            this.btnUploadImages.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUploadImages.ImageRotate = 0F;
            this.btnUploadImages.Location = new System.Drawing.Point(36, 417);
            this.btnUploadImages.Name = "btnUploadImages";
            this.btnUploadImages.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.Size = new System.Drawing.Size(61, 67);
            this.btnUploadImages.TabIndex = 79;
            this.btnUploadImages.Click += new System.EventHandler(this.btnUploadImages_Click);
            // 
            // lblImageUploads
            // 
            this.lblImageUploads.AutoSize = true;
            this.lblImageUploads.BackColor = System.Drawing.Color.Transparent;
            this.lblImageUploads.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageUploads.Location = new System.Drawing.Point(34, 349);
            this.lblImageUploads.Name = "lblImageUploads";
            this.lblImageUploads.Size = new System.Drawing.Size(209, 37);
            this.lblImageUploads.TabIndex = 78;
            this.lblImageUploads.Text = "Image Uploads";
            // 
            // flpThumbnails
            // 
            this.flpThumbnails.Location = new System.Drawing.Point(103, 397);
            this.flpThumbnails.Name = "flpThumbnails";
            this.flpThumbnails.Size = new System.Drawing.Size(717, 110);
            this.flpThumbnails.TabIndex = 77;
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.BackColor = System.Drawing.Color.Transparent;
            this.lblNote1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote1.Location = new System.Drawing.Point(572, 342);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(248, 20);
            this.lblNote1.TabIndex = 76;
            this.lblNote1.Text = "* Leave blank if there are no damages";
            // 
            // damageReportTextBox
            // 
            this.damageReportTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.damageReportTextBox.DefaultText = "dsada";
            this.damageReportTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.damageReportTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.damageReportTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.damageReportTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.damageReportTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.damageReportTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageReportTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.damageReportTextBox.Location = new System.Drawing.Point(41, 299);
            this.damageReportTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.damageReportTextBox.Multiline = true;
            this.damageReportTextBox.Name = "damageReportTextBox";
            this.damageReportTextBox.PlaceholderText = "";
            this.damageReportTextBox.SelectedText = "";
            this.damageReportTextBox.Size = new System.Drawing.Size(779, 40);
            this.damageReportTextBox.TabIndex = 75;
            // 
            // lblDamageReport
            // 
            this.lblDamageReport.AutoSize = true;
            this.lblDamageReport.BackColor = System.Drawing.Color.Transparent;
            this.lblDamageReport.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageReport.Location = new System.Drawing.Point(34, 252);
            this.lblDamageReport.Name = "lblDamageReport";
            this.lblDamageReport.Size = new System.Drawing.Size(215, 37);
            this.lblDamageReport.TabIndex = 74;
            this.lblDamageReport.Text = "Damage Report";
            // 
            // inspectionNotesTextBox
            // 
            this.inspectionNotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inspectionNotesTextBox.DefaultText = "dsada";
            this.inspectionNotesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inspectionNotesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inspectionNotesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inspectionNotesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inspectionNotesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inspectionNotesTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionNotesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inspectionNotesTextBox.Location = new System.Drawing.Point(41, 205);
            this.inspectionNotesTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.inspectionNotesTextBox.Multiline = true;
            this.inspectionNotesTextBox.Name = "inspectionNotesTextBox";
            this.inspectionNotesTextBox.PlaceholderText = "";
            this.inspectionNotesTextBox.SelectedText = "";
            this.inspectionNotesTextBox.Size = new System.Drawing.Size(779, 40);
            this.inspectionNotesTextBox.TabIndex = 73;
            // 
            // lblInspectionNotes
            // 
            this.lblInspectionNotes.AutoSize = true;
            this.lblInspectionNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblInspectionNotes.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspectionNotes.Location = new System.Drawing.Point(34, 158);
            this.lblInspectionNotes.Name = "lblInspectionNotes";
            this.lblInspectionNotes.Size = new System.Drawing.Size(228, 37);
            this.lblInspectionNotes.TabIndex = 72;
            this.lblInspectionNotes.Text = "Inspection Notes";
            // 
            // lblUsageMetrics
            // 
            this.lblUsageMetrics.AutoSize = true;
            this.lblUsageMetrics.BackColor = System.Drawing.Color.Transparent;
            this.lblUsageMetrics.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsageMetrics.Location = new System.Drawing.Point(34, 14);
            this.lblUsageMetrics.Name = "lblUsageMetrics";
            this.lblUsageMetrics.Size = new System.Drawing.Size(193, 37);
            this.lblUsageMetrics.TabIndex = 71;
            this.lblUsageMetrics.Text = "Usage Metrics";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(745, 65);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(41, 30);
            this.lblKm.TabIndex = 70;
            this.lblKm.Text = "km";
            // 
            // mileageOutTextBox
            // 
            this.mileageOutTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mileageOutTextBox.DefaultText = "";
            this.mileageOutTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mileageOutTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mileageOutTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mileageOutTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mileageOutTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mileageOutTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageOutTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mileageOutTextBox.Location = new System.Drawing.Point(633, 60);
            this.mileageOutTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.mileageOutTextBox.Multiline = true;
            this.mileageOutTextBox.Name = "mileageOutTextBox";
            this.mileageOutTextBox.PlaceholderText = "";
            this.mileageOutTextBox.ReadOnly = true;
            this.mileageOutTextBox.SelectedText = "";
            this.mileageOutTextBox.Size = new System.Drawing.Size(110, 43);
            this.mileageOutTextBox.TabIndex = 69;
            // 
            // fuelLevelOutTextBox
            // 
            this.fuelLevelOutTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fuelLevelOutTextBox.DefaultText = "";
            this.fuelLevelOutTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fuelLevelOutTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fuelLevelOutTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fuelLevelOutTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fuelLevelOutTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fuelLevelOutTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLevelOutTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fuelLevelOutTextBox.Location = new System.Drawing.Point(290, 60);
            this.fuelLevelOutTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.fuelLevelOutTextBox.Multiline = true;
            this.fuelLevelOutTextBox.Name = "fuelLevelOutTextBox";
            this.fuelLevelOutTextBox.PlaceholderText = "";
            this.fuelLevelOutTextBox.ReadOnly = true;
            this.fuelLevelOutTextBox.SelectedText = "";
            this.fuelLevelOutTextBox.Size = new System.Drawing.Size(110, 43);
            this.fuelLevelOutTextBox.TabIndex = 68;
            // 
            // lblMileageOut
            // 
            this.lblMileageOut.AutoSize = true;
            this.lblMileageOut.BackColor = System.Drawing.Color.Transparent;
            this.lblMileageOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageOut.Location = new System.Drawing.Point(423, 65);
            this.lblMileageOut.Name = "lblMileageOut";
            this.lblMileageOut.Size = new System.Drawing.Size(201, 30);
            this.lblMileageOut.TabIndex = 67;
            this.lblMileageOut.Text = "Mileage on Release";
            // 
            // lblFuelLevelOut
            // 
            this.lblFuelLevelOut.AutoSize = true;
            this.lblFuelLevelOut.BackColor = System.Drawing.Color.Transparent;
            this.lblFuelLevelOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelLevelOut.Location = new System.Drawing.Point(61, 65);
            this.lblFuelLevelOut.Name = "lblFuelLevelOut";
            this.lblFuelLevelOut.Size = new System.Drawing.Size(220, 30);
            this.lblFuelLevelOut.TabIndex = 66;
            this.lblFuelLevelOut.Text = "Fuel Level on Release";
            // 
            // lblKmIn
            // 
            this.lblKmIn.AutoSize = true;
            this.lblKmIn.BackColor = System.Drawing.Color.Transparent;
            this.lblKmIn.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmIn.Location = new System.Drawing.Point(745, 113);
            this.lblKmIn.Name = "lblKmIn";
            this.lblKmIn.Size = new System.Drawing.Size(41, 30);
            this.lblKmIn.TabIndex = 65;
            this.lblKmIn.Text = "km";
            // 
            // mileageInTextBox
            // 
            this.mileageInTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mileageInTextBox.DefaultText = "";
            this.mileageInTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mileageInTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mileageInTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mileageInTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mileageInTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mileageInTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageInTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mileageInTextBox.Location = new System.Drawing.Point(633, 108);
            this.mileageInTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.mileageInTextBox.Multiline = true;
            this.mileageInTextBox.Name = "mileageInTextBox";
            this.mileageInTextBox.PlaceholderText = "";
            this.mileageInTextBox.SelectedText = "";
            this.mileageInTextBox.Size = new System.Drawing.Size(110, 43);
            this.mileageInTextBox.TabIndex = 64;
            // 
            // fuelLevelInTextBox
            // 
            this.fuelLevelInTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fuelLevelInTextBox.DefaultText = "";
            this.fuelLevelInTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fuelLevelInTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fuelLevelInTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fuelLevelInTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fuelLevelInTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fuelLevelInTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLevelInTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fuelLevelInTextBox.Location = new System.Drawing.Point(290, 108);
            this.fuelLevelInTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.fuelLevelInTextBox.Multiline = true;
            this.fuelLevelInTextBox.Name = "fuelLevelInTextBox";
            this.fuelLevelInTextBox.PlaceholderText = "";
            this.fuelLevelInTextBox.SelectedText = "";
            this.fuelLevelInTextBox.Size = new System.Drawing.Size(110, 43);
            this.fuelLevelInTextBox.TabIndex = 63;
            // 
            // lblMileageIn
            // 
            this.lblMileageIn.AutoSize = true;
            this.lblMileageIn.BackColor = System.Drawing.Color.Transparent;
            this.lblMileageIn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageIn.Location = new System.Drawing.Point(423, 113);
            this.lblMileageIn.Name = "lblMileageIn";
            this.lblMileageIn.Size = new System.Drawing.Size(195, 30);
            this.lblMileageIn.TabIndex = 62;
            this.lblMileageIn.Text = "Mileage on Return";
            // 
            // lblFuelLevelIn
            // 
            this.lblFuelLevelIn.AutoSize = true;
            this.lblFuelLevelIn.BackColor = System.Drawing.Color.Transparent;
            this.lblFuelLevelIn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelLevelIn.Location = new System.Drawing.Point(61, 113);
            this.lblFuelLevelIn.Name = "lblFuelLevelIn";
            this.lblFuelLevelIn.Size = new System.Drawing.Size(214, 30);
            this.lblFuelLevelIn.TabIndex = 61;
            this.lblFuelLevelIn.Text = "Fuel Level on Return";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // InspectionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outerPanel);
            this.Name = "InspectionCard";
            this.Size = new System.Drawing.Size(872, 650);
            this.outerPanel.ResumeLayout(false);
            this.outerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel outerPanel;
        private System.Windows.Forms.Label lblKmIn;
        private Guna.UI2.WinForms.Guna2TextBox mileageInTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fuelLevelInTextBox;
        private System.Windows.Forms.Label lblMileageIn;
        private System.Windows.Forms.Label lblFuelLevelIn;
        private System.Windows.Forms.Label lblKm;
        private Guna.UI2.WinForms.Guna2TextBox mileageOutTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fuelLevelOutTextBox;
        private System.Windows.Forms.Label lblMileageOut;
        private System.Windows.Forms.Label lblFuelLevelOut;
        private System.Windows.Forms.Label lblUsageMetrics;
        private Guna.UI2.WinForms.Guna2TextBox inspectionNotesTextBox;
        private System.Windows.Forms.Label lblInspectionNotes;
        private System.Windows.Forms.Label lblNote1;
        private Guna.UI2.WinForms.Guna2TextBox damageReportTextBox;
        private System.Windows.Forms.Label lblDamageReport;
        private System.Windows.Forms.Label lblImageUploads;
        private System.Windows.Forms.FlowLayoutPanel flpThumbnails;
        private Guna.UI2.WinForms.Guna2ImageButton btnUploadImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPeso;
        private Guna.UI2.WinForms.Guna2TextBox additionalFeesTextBox;
        private System.Windows.Forms.Label lblAdditionalFees;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblNote2;
        private FontAwesome.Sharp.IconButton finalizeBtn;
    }
}
