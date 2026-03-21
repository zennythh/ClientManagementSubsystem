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
            this.customerBdayDTP = new System.Windows.Forms.DateTimePicker();
            this.rentalDateEndDTP = new System.Windows.Forms.DateTimePicker();
            this.rentalDateStartDTP = new System.Windows.Forms.DateTimePicker();
            this.lblBookingIDValue = new System.Windows.Forms.Label();
            this.lblRentalTimeValue = new System.Windows.Forms.Label();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.lblDateofRequestValue = new System.Windows.Forms.Label();
            this.lblDateOfRequest = new System.Windows.Forms.Label();
            this.lblRentalPeriod = new System.Windows.Forms.Label();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.lblCustomerBirthday = new System.Windows.Forms.Label();
            this.customerContactNumTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerContactNum = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.customerLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustomerLicense = new System.Windows.Forms.Label();
            this.customerAgeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblto = new System.Windows.Forms.Label();
            this.vehicleLicenseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.vehicleNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.rejectBtn = new FontAwesome.Sharp.IconButton();
            this.approveBtn = new FontAwesome.Sharp.IconButton();
            this.outerConflictPanel = new System.Windows.Forms.Panel();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoBookingConflicts = new System.Windows.Forms.Label();
            this.lblBookingConflicts = new System.Windows.Forms.Label();
            this.innerHeaderPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pendingSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.noBookingSelectedPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.bookingPanels.SuspendLayout();
            this.bookingDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            this.outerConflictPanel.SuspendLayout();
            this.conflictFlowPanel.SuspendLayout();
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
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1622, 943);
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
            this.bookingPanels.Location = new System.Drawing.Point(3, 144);
            this.bookingPanels.Name = "bookingPanels";
            this.bookingPanels.RowCount = 1;
            this.bookingPanels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bookingPanels.Size = new System.Drawing.Size(1616, 796);
            this.bookingPanels.TabIndex = 0;
            // 
            // bookingListPanel
            // 
            this.bookingListPanel.AutoScroll = true;
            this.bookingListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingListPanel.Location = new System.Drawing.Point(3, 3);
            this.bookingListPanel.Name = "bookingListPanel";
            this.bookingListPanel.Size = new System.Drawing.Size(640, 790);
            this.bookingListPanel.TabIndex = 1;
            // 
            // bookingDetailsPanel
            // 
            this.bookingDetailsPanel.BorderRadius = 5;
            this.bookingDetailsPanel.Controls.Add(this.lblPriceValue);
            this.bookingDetailsPanel.Controls.Add(this.lblPrice);
            this.bookingDetailsPanel.Controls.Add(this.customerBdayDTP);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateEndDTP);
            this.bookingDetailsPanel.Controls.Add(this.rentalDateStartDTP);
            this.bookingDetailsPanel.Controls.Add(this.lblBookingIDValue);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTimeValue);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalTime);
            this.bookingDetailsPanel.Controls.Add(this.lblDateofRequestValue);
            this.bookingDetailsPanel.Controls.Add(this.lblDateOfRequest);
            this.bookingDetailsPanel.Controls.Add(this.lblRentalPeriod);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerAge);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerBirthday);
            this.bookingDetailsPanel.Controls.Add(this.customerContactNumTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerContactNum);
            this.bookingDetailsPanel.Controls.Add(this.customerEmailTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerEmail);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerInfo);
            this.bookingDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLastName);
            this.bookingDetailsPanel.Controls.Add(this.customerLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblCustomerLicense);
            this.bookingDetailsPanel.Controls.Add(this.customerAgeTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblto);
            this.bookingDetailsPanel.Controls.Add(this.vehicleLicenseTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblLicenseNum);
            this.bookingDetailsPanel.Controls.Add(this.vehiclePictureBox);
            this.bookingDetailsPanel.Controls.Add(this.lblBookingid);
            this.bookingDetailsPanel.Controls.Add(this.vehicleNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblVehicleName);
            this.bookingDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.bookingDetailsPanel.Controls.Add(this.lblFirstName);
            this.bookingDetailsPanel.Controls.Add(this.rejectBtn);
            this.bookingDetailsPanel.Controls.Add(this.approveBtn);
            this.bookingDetailsPanel.Controls.Add(this.outerConflictPanel);
            this.bookingDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingDetailsPanel.FillColor = System.Drawing.Color.White;
            this.bookingDetailsPanel.Location = new System.Drawing.Point(649, 3);
            this.bookingDetailsPanel.Name = "bookingDetailsPanel";
            this.bookingDetailsPanel.Padding = new System.Windows.Forms.Padding(20);
            this.bookingDetailsPanel.Size = new System.Drawing.Size(964, 790);
            this.bookingDetailsPanel.TabIndex = 2;
            // 
            // customerBdayDTP
            // 
            this.customerBdayDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBdayDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.customerBdayDTP.CustomFormat = "MMMM dd, yyyy";
            this.customerBdayDTP.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBdayDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customerBdayDTP.Location = new System.Drawing.Point(117, 413);
            this.customerBdayDTP.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.customerBdayDTP.MinDate = new System.DateTime(1910, 12, 31, 0, 0, 0, 0);
            this.customerBdayDTP.Name = "customerBdayDTP";
            this.customerBdayDTP.Size = new System.Drawing.Size(220, 33);
            this.customerBdayDTP.TabIndex = 44;
            this.customerBdayDTP.Value = new System.DateTime(2026, 11, 19, 0, 0, 0, 0);
            // 
            // rentalDateEndDTP
            // 
            this.rentalDateEndDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateEndDTP.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.rentalDateEndDTP.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateEndDTP.Location = new System.Drawing.Point(669, 486);
            this.rentalDateEndDTP.Name = "rentalDateEndDTP";
            this.rentalDateEndDTP.Size = new System.Drawing.Size(246, 33);
            this.rentalDateEndDTP.TabIndex = 43;
            this.rentalDateEndDTP.ValueChanged += new System.EventHandler(this.rentalDate_ValueChanged);
            // 
            // rentalDateStartDTP
            // 
            this.rentalDateStartDTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.CalendarTitleForeColor = System.Drawing.Color.Azure;
            this.rentalDateStartDTP.CustomFormat = " MM/dd/yyyy hh:mm tt";
            this.rentalDateStartDTP.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateStartDTP.Location = new System.Drawing.Point(669, 447);
            this.rentalDateStartDTP.Name = "rentalDateStartDTP";
            this.rentalDateStartDTP.Size = new System.Drawing.Size(246, 33);
            this.rentalDateStartDTP.TabIndex = 42;
            this.rentalDateStartDTP.ValueChanged += new System.EventHandler(this.rentalDate_ValueChanged);
            // 
            // lblBookingIDValue
            // 
            this.lblBookingIDValue.AutoSize = true;
            this.lblBookingIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIDValue.Location = new System.Drawing.Point(159, 20);
            this.lblBookingIDValue.Name = "lblBookingIDValue";
            this.lblBookingIDValue.Size = new System.Drawing.Size(121, 30);
            this.lblBookingIDValue.TabIndex = 34;
            this.lblBookingIDValue.Text = "321312312";
            // 
            // lblRentalTimeValue
            // 
            this.lblRentalTimeValue.AutoSize = true;
            this.lblRentalTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTimeValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTimeValue.Location = new System.Drawing.Point(516, 450);
            this.lblRentalTimeValue.Name = "lblRentalTimeValue";
            this.lblRentalTimeValue.Size = new System.Drawing.Size(138, 30);
            this.lblRentalTimeValue.TabIndex = 33;
            this.lblRentalTimeValue.Text = "0 day 2 hours";
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.AutoSize = true;
            this.lblRentalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalTime.Location = new System.Drawing.Point(417, 450);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(106, 30);
            this.lblRentalTime.TabIndex = 32;
            this.lblRentalTime.Text = "Duration:";
            // 
            // lblDateofRequestValue
            // 
            this.lblDateofRequestValue.AutoSize = true;
            this.lblDateofRequestValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDateofRequestValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofRequestValue.Location = new System.Drawing.Point(80, 489);
            this.lblDateofRequestValue.Name = "lblDateofRequestValue";
            this.lblDateofRequestValue.Size = new System.Drawing.Size(211, 30);
            this.lblDateofRequestValue.TabIndex = 31;
            this.lblDateofRequestValue.Text = "02/02/2022 02:02 AM";
            // 
            // lblDateOfRequest
            // 
            this.lblDateOfRequest.AutoSize = true;
            this.lblDateOfRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfRequest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfRequest.Location = new System.Drawing.Point(92, 459);
            this.lblDateOfRequest.Name = "lblDateOfRequest";
            this.lblDateOfRequest.Size = new System.Drawing.Size(181, 30);
            this.lblDateOfRequest.TabIndex = 30;
            this.lblDateOfRequest.Text = "Date of Request: ";
            // 
            // lblRentalPeriod
            // 
            this.lblRentalPeriod.AutoSize = true;
            this.lblRentalPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalPeriod.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPeriod.Location = new System.Drawing.Point(664, 412);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(144, 30);
            this.lblRentalPeriod.TabIndex = 28;
            this.lblRentalPeriod.Text = "Rental Period";
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAge.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAge.Location = new System.Drawing.Point(360, 413);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(52, 30);
            this.lblCustomerAge.TabIndex = 26;
            this.lblCustomerAge.Text = "Age";
            // 
            // lblCustomerBirthday
            // 
            this.lblCustomerBirthday.AutoSize = true;
            this.lblCustomerBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerBirthday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBirthday.Location = new System.Drawing.Point(14, 417);
            this.lblCustomerBirthday.Name = "lblCustomerBirthday";
            this.lblCustomerBirthday.Size = new System.Drawing.Size(97, 30);
            this.lblCustomerBirthday.TabIndex = 24;
            this.lblCustomerBirthday.Text = "Birthday";
            // 
            // customerContactNumTextBox
            // 
            this.customerContactNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerContactNumTextBox.DefaultText = "";
            this.customerContactNumTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerContactNumTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerContactNumTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerContactNumTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerContactNumTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerContactNumTextBox.Location = new System.Drawing.Point(242, 257);
            this.customerContactNumTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerContactNumTextBox.Multiline = true;
            this.customerContactNumTextBox.Name = "customerContactNumTextBox";
            this.customerContactNumTextBox.PlaceholderText = "";
            this.customerContactNumTextBox.SelectedText = "";
            this.customerContactNumTextBox.Size = new System.Drawing.Size(171, 43);
            this.customerContactNumTextBox.TabIndex = 23;
            // 
            // lblCustomerContactNum
            // 
            this.lblCustomerContactNum.AutoSize = true;
            this.lblCustomerContactNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerContactNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNum.Location = new System.Drawing.Point(242, 221);
            this.lblCustomerContactNum.Name = "lblCustomerContactNum";
            this.lblCustomerContactNum.Size = new System.Drawing.Size(176, 30);
            this.lblCustomerContactNum.TabIndex = 22;
            this.lblCustomerContactNum.Text = "Contact Number";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerEmailTextBox.DefaultText = "";
            this.customerEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerEmailTextBox.Location = new System.Drawing.Point(28, 350);
            this.customerEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerEmailTextBox.Multiline = true;
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.PlaceholderText = "";
            this.customerEmailTextBox.SelectedText = "";
            this.customerEmailTextBox.Size = new System.Drawing.Size(385, 43);
            this.customerEmailTextBox.TabIndex = 21;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(28, 310);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(150, 30);
            this.lblCustomerEmail.TabIndex = 20;
            this.lblCustomerEmail.Text = "Email Address";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(21, 73);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(196, 37);
            this.lblCustomerInfo.TabIndex = 19;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "fs";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(242, 168);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(171, 43);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(242, 128);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 30);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name";
            // 
            // customerLicenseTextBox
            // 
            this.customerLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerLicenseTextBox.DefaultText = "";
            this.customerLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerLicenseTextBox.Location = new System.Drawing.Point(28, 257);
            this.customerLicenseTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.customerLicenseTextBox.Multiline = true;
            this.customerLicenseTextBox.Name = "customerLicenseTextBox";
            this.customerLicenseTextBox.PlaceholderText = "";
            this.customerLicenseTextBox.SelectedText = "";
            this.customerLicenseTextBox.Size = new System.Drawing.Size(171, 43);
            this.customerLicenseTextBox.TabIndex = 16;
            // 
            // lblCustomerLicense
            // 
            this.lblCustomerLicense.AutoSize = true;
            this.lblCustomerLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLicense.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLicense.Location = new System.Drawing.Point(28, 221);
            this.lblCustomerLicense.Name = "lblCustomerLicense";
            this.lblCustomerLicense.Size = new System.Drawing.Size(171, 30);
            this.lblCustomerLicense.TabIndex = 15;
            this.lblCustomerLicense.Text = "License Number";
            // 
            // customerAgeTextBox
            // 
            this.customerAgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerAgeTextBox.DefaultText = "32";
            this.customerAgeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerAgeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerAgeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAgeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAgeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAgeTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAgeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAgeTextBox.Location = new System.Drawing.Point(418, 412);
            this.customerAgeTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.customerAgeTextBox.Multiline = true;
            this.customerAgeTextBox.Name = "customerAgeTextBox";
            this.customerAgeTextBox.PlaceholderText = "";
            this.customerAgeTextBox.ReadOnly = true;
            this.customerAgeTextBox.SelectedText = "";
            this.customerAgeTextBox.Size = new System.Drawing.Size(54, 34);
            this.customerAgeTextBox.TabIndex = 14;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.BackColor = System.Drawing.Color.Transparent;
            this.lblto.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(921, 450);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(32, 30);
            this.lblto.TabIndex = 13;
            this.lblto.Text = "to";
            // 
            // vehicleLicenseTextBox
            // 
            this.vehicleLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleLicenseTextBox.DefaultText = "";
            this.vehicleLicenseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleLicenseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleLicenseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleLicenseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLicenseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleLicenseTextBox.Location = new System.Drawing.Point(753, 350);
            this.vehicleLicenseTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.vehicleLicenseTextBox.Multiline = true;
            this.vehicleLicenseTextBox.Name = "vehicleLicenseTextBox";
            this.vehicleLicenseTextBox.PlaceholderText = "";
            this.vehicleLicenseTextBox.ReadOnly = true;
            this.vehicleLicenseTextBox.SelectedText = "";
            this.vehicleLicenseTextBox.Size = new System.Drawing.Size(185, 43);
            this.vehicleLicenseTextBox.TabIndex = 10;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNum.Location = new System.Drawing.Point(748, 310);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(139, 30);
            this.lblLicenseNum.TabIndex = 9;
            this.lblLicenseNum.Text = "License Plate";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.vehiclePictureBox.ErrorImage = global::ClientManagementSubsystem.Properties.Resources.defaultVehicle;
            this.vehiclePictureBox.Image = global::ClientManagementSubsystem.Properties.Resources.defaultVehicle;
            this.vehiclePictureBox.Location = new System.Drawing.Point(466, 33);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(475, 268);
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehiclePictureBox.TabIndex = 8;
            this.vehiclePictureBox.TabStop = false;
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingid.Location = new System.Drawing.Point(23, 20);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(130, 30);
            this.lblBookingid.TabIndex = 6;
            this.lblBookingid.Text = "Booking ID:";
            // 
            // vehicleNameTextBox
            // 
            this.vehicleNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleNameTextBox.DefaultText = "";
            this.vehicleNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleNameTextBox.Location = new System.Drawing.Point(466, 350);
            this.vehicleNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.vehicleNameTextBox.Multiline = true;
            this.vehicleNameTextBox.Name = "vehicleNameTextBox";
            this.vehicleNameTextBox.PlaceholderText = "";
            this.vehicleNameTextBox.ReadOnly = true;
            this.vehicleNameTextBox.SelectedText = "";
            this.vehicleNameTextBox.Size = new System.Drawing.Size(247, 43);
            this.vehicleNameTextBox.TabIndex = 5;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleName.Location = new System.Drawing.Point(466, 310);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(215, 30);
            this.lblVehicleName.TabIndex = 4;
            this.lblVehicleName.Text = "Vehicle to be Rented";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(28, 168);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(171, 43);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(28, 128);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(119, 30);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
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
            this.rejectBtn.Location = new System.Drawing.Point(529, 717);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(184, 58);
            this.rejectBtn.TabIndex = 1;
            this.rejectBtn.Text = " Reject";
            this.rejectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rejectBtn.UseVisualStyleBackColor = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
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
            this.approveBtn.Location = new System.Drawing.Point(252, 717);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(184, 58);
            this.approveBtn.TabIndex = 0;
            this.approveBtn.Text = "Approve";
            this.approveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.approveBtn.UseVisualStyleBackColor = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // outerConflictPanel
            // 
            this.outerConflictPanel.BackColor = System.Drawing.Color.Transparent;
            this.outerConflictPanel.Controls.Add(this.conflictFlowPanel);
            this.outerConflictPanel.Controls.Add(this.lblBookingConflicts);
            this.outerConflictPanel.Location = new System.Drawing.Point(0, 533);
            this.outerConflictPanel.Name = "outerConflictPanel";
            this.outerConflictPanel.Size = new System.Drawing.Size(964, 257);
            this.outerConflictPanel.TabIndex = 40;
            // 
            // conflictFlowPanel
            // 
            this.conflictFlowPanel.AutoScroll = true;
            this.conflictFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.conflictFlowPanel.Controls.Add(this.lblNoBookingConflicts);
            this.conflictFlowPanel.Location = new System.Drawing.Point(33, 31);
            this.conflictFlowPanel.Name = "conflictFlowPanel";
            this.conflictFlowPanel.Size = new System.Drawing.Size(905, 147);
            this.conflictFlowPanel.TabIndex = 39;
            this.conflictFlowPanel.WrapContents = false;
            // 
            // lblNoBookingConflicts
            // 
            this.lblNoBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblNoBookingConflicts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBookingConflicts.ForeColor = System.Drawing.Color.Green;
            this.lblNoBookingConflicts.Location = new System.Drawing.Point(3, 0);
            this.lblNoBookingConflicts.Name = "lblNoBookingConflicts";
            this.lblNoBookingConflicts.Size = new System.Drawing.Size(888, 68);
            this.lblNoBookingConflicts.TabIndex = 39;
            this.lblNoBookingConflicts.Text = "No Booking Conflicts!";
            this.lblNoBookingConflicts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoBookingConflicts.Visible = false;
            // 
            // lblBookingConflicts
            // 
            this.lblBookingConflicts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingConflicts.AutoSize = true;
            this.lblBookingConflicts.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingConflicts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingConflicts.Location = new System.Drawing.Point(382, -2);
            this.lblBookingConflicts.Name = "lblBookingConflicts";
            this.lblBookingConflicts.Size = new System.Drawing.Size(188, 30);
            this.lblBookingConflicts.TabIndex = 38;
            this.lblBookingConflicts.Text = "Booking Conflicts";
            this.lblBookingConflicts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // innerHeaderPanel
            // 
            this.innerHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.BorderRadius = 25;
            this.innerHeaderPanel.Controls.Add(this.noBookingSelectedPanel);
            this.innerHeaderPanel.Controls.Add(this.pendingSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedBtn);
            this.innerHeaderPanel.Controls.Add(this.pendingBtn);
            this.innerHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerHeaderPanel.FillColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.innerHeaderPanel.Name = "innerHeaderPanel";
            this.innerHeaderPanel.Size = new System.Drawing.Size(1616, 135);
            this.innerHeaderPanel.TabIndex = 4;
            this.innerHeaderPanel.UseTransparentBackground = true;
            // 
            // pendingSelected
            // 
            this.pendingSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.Location = new System.Drawing.Point(43, 105);
            this.pendingSelected.Margin = new System.Windows.Forms.Padding(0);
            this.pendingSelected.Name = "pendingSelected";
            this.pendingSelected.PolygonSkip = 1;
            this.pendingSelected.Rotate = 0F;
            this.pendingSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.pendingSelected.Size = new System.Drawing.Size(186, 5);
            this.pendingSelected.TabIndex = 2;
            this.pendingSelected.Text = "guna2Shapes1";
            this.pendingSelected.Zoom = 100;
            // 
            // approvedSelected
            // 
            this.approvedSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.approvedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedSelected.Location = new System.Drawing.Point(235, 105);
            this.approvedSelected.Name = "approvedSelected";
            this.approvedSelected.PolygonSkip = 1;
            this.approvedSelected.Rotate = 0F;
            this.approvedSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.approvedSelected.Size = new System.Drawing.Size(215, 5);
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
            this.approvedBtn.Location = new System.Drawing.Point(235, 36);
            this.approvedBtn.Name = "approvedBtn";
            this.approvedBtn.PressedColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Size = new System.Drawing.Size(215, 63);
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
            this.pendingBtn.Location = new System.Drawing.Point(43, 36);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.PressedColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Size = new System.Drawing.Size(186, 63);
            this.pendingBtn.TabIndex = 0;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(483, 486);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(80, 30);
            this.lblPriceValue.TabIndex = 46;
            this.lblPriceValue.Text = "P20002";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(418, 486);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 30);
            this.lblPrice.TabIndex = 45;
            this.lblPrice.Text = "Price:";
            // 
            // noBookingSelectedPanel
            // 
            this.noBookingSelectedPanel.BackColor = System.Drawing.Color.Transparent;
            this.noBookingSelectedPanel.Location = new System.Drawing.Point(171, 11);
            this.noBookingSelectedPanel.Name = "noBookingSelectedPanel";
            this.noBookingSelectedPanel.Size = new System.Drawing.Size(935, 765);
            this.noBookingSelectedPanel.TabIndex = 47;
            this.noBookingSelectedPanel.Visible = false;
            // 
            // bookingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "bookingsUserControl";
            this.Size = new System.Drawing.Size(1622, 943);
            this.tableLayoutPanel.ResumeLayout(false);
            this.bookingPanels.ResumeLayout(false);
            this.bookingDetailsPanel.ResumeLayout(false);
            this.bookingDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            this.outerConflictPanel.ResumeLayout(false);
            this.outerConflictPanel.PerformLayout();
            this.conflictFlowPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblBookingIDValue;
        private System.Windows.Forms.Label lblRentalTimeValue;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.Label lblDateofRequestValue;
        private System.Windows.Forms.Label lblDateOfRequest;
        private System.Windows.Forms.Label lblRentalPeriod;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.Label lblCustomerBirthday;
        private Guna.UI2.WinForms.Guna2TextBox customerContactNumTextBox;
        private System.Windows.Forms.Label lblCustomerContactNum;
        private Guna.UI2.WinForms.Guna2TextBox customerEmailTextBox;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerInfo;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox customerLicenseTextBox;
        private System.Windows.Forms.Label lblCustomerLicense;
        private Guna.UI2.WinForms.Guna2TextBox customerAgeTextBox;
        private System.Windows.Forms.Label lblto;
        private Guna.UI2.WinForms.Guna2TextBox vehicleLicenseTextBox;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private System.Windows.Forms.Label lblBookingid;
        private Guna.UI2.WinForms.Guna2TextBox vehicleNameTextBox;
        private System.Windows.Forms.Label lblVehicleName;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private FontAwesome.Sharp.IconButton rejectBtn;
        private FontAwesome.Sharp.IconButton approveBtn;
        private System.Windows.Forms.Label lblBookingConflicts;
        private System.Windows.Forms.FlowLayoutPanel conflictFlowPanel;
        private System.Windows.Forms.Label lblNoBookingConflicts;
        private System.Windows.Forms.Panel outerConflictPanel;
        private System.Windows.Forms.DateTimePicker rentalDateStartDTP;
        private System.Windows.Forms.DateTimePicker rentalDateEndDTP;
        private System.Windows.Forms.DateTimePicker customerBdayDTP;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel noBookingSelectedPanel;
    }
}
