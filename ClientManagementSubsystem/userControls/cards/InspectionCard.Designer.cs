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
            this.lblKmIn = new System.Windows.Forms.Label();
            this.mileageInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fuelLevelInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMileageIn = new System.Windows.Forms.Label();
            this.lblFuelLevelIn = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.mileageOutTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fuelLevelOutTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMileageOut = new System.Windows.Forms.Label();
            this.lblFuelLevelOut = new System.Windows.Forms.Label();
            this.lblUsageMetrics = new System.Windows.Forms.Label();
            this.lblInspectionNotes = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDamageReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.lblImageUploads = new System.Windows.Forms.Label();
            this.btnUploadImages = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.outerPanel.Controls.Add(this.btnUploadImages);
            this.outerPanel.Controls.Add(this.lblImageUploads);
            this.outerPanel.Controls.Add(this.flpThumbnails);
            this.outerPanel.Controls.Add(this.label1);
            this.outerPanel.Controls.Add(this.guna2TextBox2);
            this.outerPanel.Controls.Add(this.lblDamageReport);
            this.outerPanel.Controls.Add(this.guna2TextBox1);
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
            this.outerPanel.Size = new System.Drawing.Size(872, 536);
            this.outerPanel.TabIndex = 0;
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "dsada";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(41, 205);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(779, 40);
            this.guna2TextBox1.TabIndex = 73;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "dsada";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(41, 299);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(779, 40);
            this.guna2TextBox2.TabIndex = 75;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "* Leave blank if there are no damages";
            // 
            // flpThumbnails
            // 
            this.flpThumbnails.Location = new System.Drawing.Point(41, 398);
            this.flpThumbnails.Name = "flpThumbnails";
            this.flpThumbnails.Size = new System.Drawing.Size(471, 110);
            this.flpThumbnails.TabIndex = 77;
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
            // btnUploadImages
            // 
            this.btnUploadImages.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.Image = global::ClientManagementSubsystem.Properties.Resources.file_up__1_;
            this.btnUploadImages.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUploadImages.ImageRotate = 0F;
            this.btnUploadImages.Location = new System.Drawing.Point(521, 421);
            this.btnUploadImages.Name = "btnUploadImages";
            this.btnUploadImages.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUploadImages.Size = new System.Drawing.Size(61, 67);
            this.btnUploadImages.TabIndex = 79;
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
            this.Size = new System.Drawing.Size(872, 536);
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lblInspectionNotes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label lblDamageReport;
        private System.Windows.Forms.Label lblImageUploads;
        private System.Windows.Forms.FlowLayoutPanel flpThumbnails;
        private Guna.UI2.WinForms.Guna2ImageButton btnUploadImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
