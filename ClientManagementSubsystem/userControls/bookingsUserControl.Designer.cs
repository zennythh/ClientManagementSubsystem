namespace ClientManagementSubsystem
{
    partial class bookingsUserControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bookingPanels = new System.Windows.Forms.TableLayoutPanel();
            this.bookingListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bookingDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblto = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseNumtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookingidtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.vehicleNametxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.clientNametxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.rejectBtn = new FontAwesome.Sharp.IconButton();
            this.approveBtn = new FontAwesome.Sharp.IconButton();
            this.innerHeaderPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pendingSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel.SuspendLayout();
            this.bookingPanels.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.innerHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.bookingPanels, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.innerHeaderPanel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(2433, 1451);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // bookingPanels
            // 
            this.bookingPanels.ColumnCount = 2;
            this.bookingPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bookingPanels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bookingPanels.Controls.Add(this.bookingListPanel, 0, 0);
            this.bookingPanels.Controls.Add(this.bookingDetailsPanel, 1, 0);
            this.bookingPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingPanels.Location = new System.Drawing.Point(4, 222);
            this.bookingPanels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingPanels.Name = "bookingPanels";
            this.bookingPanels.RowCount = 1;
            this.bookingPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bookingPanels.Size = new System.Drawing.Size(2425, 1224);
            this.bookingPanels.TabIndex = 0;
            // 
            // bookingListPanel
            // 
            this.bookingListPanel.AutoScroll = true;
            this.bookingListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingListPanel.Location = new System.Drawing.Point(4, 5);
            this.bookingListPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingListPanel.Name = "bookingListPanel";
            this.bookingListPanel.Size = new System.Drawing.Size(962, 1214);
            this.bookingListPanel.TabIndex = 1;
            // 
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.BorderRadius = 5;
            this.bookingDetailsPanel.Controls.Add(this.guna2TextBox3);
            this.bookingDetailsPanel.Controls.Add(this.label2);
            this.bookingDetailsPanel.Controls.Add(this.guna2TextBox2);
            this.bookingDetailsPanel.Controls.Add(this.lblto);
            this.bookingDetailsPanel.Controls.Add(this.guna2TextBox1);
            this.bookingDetailsPanel.Controls.Add(this.label1);
            this.bookingDetailsPanel.Controls.Add(this.licenseNumtxtbox);
            this.bookingDetailsPanel.Controls.Add(this.lblLicenseNum);
            this.bookingDetailsPanel.Controls.Add(this.pictureBox1);
            this.bookingDetailsPanel.Controls.Add(this.bookingidtxtbox);
            this.bookingDetailsPanel.Controls.Add(this.lblBookingid);
            this.bookingDetailsPanel.Controls.Add(this.vehicleNametxtbox);
            this.bookingDetailsPanel.Controls.Add(this.lblVehicleName);
            this.bookingDetailsPanel.Controls.Add(this.clientNametxtbox);
            this.bookingDetailsPanel.Controls.Add(this.lblClientName);
            this.bookingDetailsPanel.Controls.Add(this.rejectBtn);
            this.bookingDetailsPanel.Controls.Add(this.approveBtn);
            this.bookingDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsPanel.FillColor = System.Drawing.Color.White;
            this.bookingDetailsPanel.Location = new System.Drawing.Point(974, 5);
            this.bookingDetailsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.bookingDetailsPanel.Size = new System.Drawing.Size(1447, 1214);
            this.bookingDetailsPanel.TabIndex = 2;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(34, 329);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(590, 55);
            this.guna2TextBox3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client\'s License #";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(372, 511);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(272, 55);
            this.guna2TextBox2.TabIndex = 14;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(315, 520);
            this.lblto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(48, 45);
            this.lblto.TabIndex = 13;
            this.lblto.Text = "to";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(34, 511);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(272, 55);
            this.guna2TextBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Renting Date";
            // 
            // licenseNumtxtbox
            // 
            this.licenseNumtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licenseNumtxtbox.DefaultText = "";
            this.licenseNumtxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.licenseNumtxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.licenseNumtxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseNumtxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.licenseNumtxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseNumtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licenseNumtxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.licenseNumtxtbox.Location = new System.Drawing.Point(1140, 511);
            this.licenseNumtxtbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.licenseNumtxtbox.Name = "licenseNumtxtbox";
            this.licenseNumtxtbox.PlaceholderText = "";
            this.licenseNumtxtbox.ReadOnly = true;
            this.licenseNumtxtbox.SelectedText = "";
            this.licenseNumtxtbox.Size = new System.Drawing.Size(272, 55);
            this.licenseNumtxtbox.TabIndex = 10;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNum.Location = new System.Drawing.Point(1140, 460);
            this.lblLicenseNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(239, 45);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Plate #";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClientManagementSubsystem.Properties.Resources.defaultVehicle;
            this.pictureBox1.Location = new System.Drawing.Point(652, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bookingidtxtbox
            // 
            this.bookingidtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookingidtxtbox.DefaultText = "";
            this.bookingidtxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookingidtxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookingidtxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingidtxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingidtxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingidtxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookingidtxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingidtxtbox.Location = new System.Drawing.Point(238, 31);
            this.bookingidtxtbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bookingidtxtbox.Name = "bookingidtxtbox";
            this.bookingidtxtbox.PlaceholderText = "";
            this.bookingidtxtbox.ReadOnly = true;
            this.bookingidtxtbox.SelectedText = "";
            this.bookingidtxtbox.Size = new System.Drawing.Size(226, 46);
            this.bookingidtxtbox.TabIndex = 7;
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingid.Location = new System.Drawing.Point(34, 31);
            this.lblBookingid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(199, 45);
            this.lblBookingid.TabIndex = 6;
            this.lblBookingid.Text = "Booking ID:";
            // 
            // vehicleNametxtbox
            // 
            this.vehicleNametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleNametxtbox.DefaultText = "";
            this.vehicleNametxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleNametxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleNametxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNametxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNametxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNametxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vehicleNametxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNametxtbox.Location = new System.Drawing.Point(699, 511);
            this.vehicleNametxtbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.vehicleNametxtbox.Name = "vehicleNametxtbox";
            this.vehicleNametxtbox.PlaceholderText = "";
            this.vehicleNametxtbox.ReadOnly = true;
            this.vehicleNametxtbox.SelectedText = "";
            this.vehicleNametxtbox.Size = new System.Drawing.Size(417, 55);
            this.vehicleNametxtbox.TabIndex = 5;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.Location = new System.Drawing.Point(699, 460);
            this.lblVehicleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(326, 45);
            this.lblVehicleName.TabIndex = 4;
            this.lblVehicleName.Text = "Vehicle to be Rented";
            // 
            // clientNametxtbox
            // 
            this.clientNametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientNametxtbox.DefaultText = "";
            this.clientNametxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientNametxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientNametxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientNametxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientNametxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientNametxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientNametxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientNametxtbox.Location = new System.Drawing.Point(34, 172);
            this.clientNametxtbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientNametxtbox.Name = "clientNametxtbox";
            this.clientNametxtbox.PlaceholderText = "";
            this.clientNametxtbox.ReadOnly = true;
            this.clientNametxtbox.SelectedText = "";
            this.clientNametxtbox.Size = new System.Drawing.Size(590, 55);
            this.clientNametxtbox.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(34, 122);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(244, 45);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Name of Client";
            // 
            // rejectBtn
            // 
            this.rejectBtn.BackColor = System.Drawing.Color.Tomato;
            this.rejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectBtn.ForeColor = System.Drawing.Color.Black;
            this.rejectBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.rejectBtn.IconColor = System.Drawing.Color.Black;
            this.rejectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rejectBtn.IconSize = 40;
            this.rejectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rejectBtn.Location = new System.Drawing.Point(794, 1040);
            this.rejectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(276, 89);
            this.rejectBtn.TabIndex = 1;
            this.rejectBtn.Text = " Reject";
            this.rejectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rejectBtn.UseVisualStyleBackColor = false;
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveBtn.ForeColor = System.Drawing.Color.Black;
            this.approveBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.approveBtn.IconColor = System.Drawing.Color.Black;
            this.approveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.approveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approveBtn.Location = new System.Drawing.Point(378, 1040);
            this.approveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(276, 89);
            this.approveBtn.TabIndex = 0;
            this.approveBtn.Text = "Approve";
            this.approveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.approveBtn.UseVisualStyleBackColor = false;
            // 
            // innerHeaderPanel
            // 
            this.innerHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.BorderRadius = 25;
            this.innerHeaderPanel.Controls.Add(this.pendingSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedBtn);
            this.innerHeaderPanel.Controls.Add(this.pendingBtn);
            this.innerHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerHeaderPanel.FillColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.Location = new System.Drawing.Point(4, 5);
            this.innerHeaderPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.innerHeaderPanel.Name = "innerHeaderPanel";
            this.innerHeaderPanel.Size = new System.Drawing.Size(2425, 207);
            this.innerHeaderPanel.TabIndex = 4;
            this.innerHeaderPanel.UseTransparentBackground = true;
            // 
            // pendingSelected
            // 
            this.pendingSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.Location = new System.Drawing.Point(64, 162);
            this.pendingSelected.Margin = new System.Windows.Forms.Padding(0);
            this.pendingSelected.Name = "pendingSelected";
            this.pendingSelected.PolygonSkip = 1;
            this.pendingSelected.Rotate = 0F;
            this.pendingSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.pendingSelected.Size = new System.Drawing.Size(279, 8);
            this.pendingSelected.TabIndex = 2;
            this.pendingSelected.Text = "guna2Shapes1";
            this.pendingSelected.Zoom = 100;
            // 
            // approvedSelected
            // 
            this.approvedSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedSelected.Location = new System.Drawing.Point(352, 162);
            this.approvedSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.approvedSelected.Name = "approvedSelected";
            this.approvedSelected.PolygonSkip = 1;
            this.approvedSelected.Rotate = 0F;
            this.approvedSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.approvedSelected.Size = new System.Drawing.Size(322, 8);
            this.approvedSelected.TabIndex = 3;
            this.approvedSelected.Text = "guna2Shapes2";
            this.approvedSelected.Zoom = 100;
            // 
            // approvedBtn
            // 
            this.approvedBtn.BackColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approvedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approvedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approvedBtn.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedBtn.Location = new System.Drawing.Point(352, 55);
            this.approvedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.approvedBtn.Name = "approvedBtn";
            this.approvedBtn.PressedColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Size = new System.Drawing.Size(322, 97);
            this.approvedBtn.TabIndex = 1;
            this.approvedBtn.Text = "Approved";
            this.approvedBtn.Click += new System.EventHandler(this.approvedBtn_Click);
            // 
            // pendingBtn
            // 
            this.pendingBtn.BackColor = System.Drawing.Color.Transparent;
            this.pendingBtn.BorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pendingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pendingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pendingBtn.FillColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingBtn.Location = new System.Drawing.Point(64, 55);
            this.pendingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.PressedColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Size = new System.Drawing.Size(279, 97);
            this.pendingBtn.TabIndex = 0;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // bookingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "bookingsUserControl";
            this.Size = new System.Drawing.Size(2433, 1451);
            this.tableLayoutPanel.ResumeLayout(false);
            this.bookingPanels.ResumeLayout(false);
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.innerHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button pendingBtn;
        private Guna.UI2.WinForms.Guna2Button approvedBtn;
        private Guna.UI2.WinForms.Guna2Shapes pendingSelected;
        private Guna.UI2.WinForms.Guna2Shapes approvedSelected;
        private System.Windows.Forms.FlowLayoutPanel bookingListPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel innerHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel bookingPanels;
        private Guna.UI2.WinForms.Guna2Panel bookingDetailsPanel;
        private FontAwesome.Sharp.IconButton approveBtn;
        private FontAwesome.Sharp.IconButton rejectBtn;
        private Guna.UI2.WinForms.Guna2TextBox clientNametxtbox;
        private System.Windows.Forms.Label lblClientName;
        private Guna.UI2.WinForms.Guna2TextBox bookingidtxtbox;
        private System.Windows.Forms.Label lblBookingid;
        private Guna.UI2.WinForms.Guna2TextBox vehicleNametxtbox;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox licenseNumtxtbox;
        private System.Windows.Forms.Label lblLicenseNum;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label lblto;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
    }
}
