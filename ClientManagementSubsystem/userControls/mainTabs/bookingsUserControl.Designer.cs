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
            this.tabContentPanel = new System.Windows.Forms.Panel();
            this.innerHeaderPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.clearSearchbarBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searchBarTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dismissedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.completedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.completedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dismissedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingBtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblBookingid = new System.Windows.Forms.Label();
            this.vehicleNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.outerConflictPanel = new System.Windows.Forms.Panel();
            this.conflictFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoBookingConflicts = new System.Windows.Forms.Label();
            this.lblBookingConflicts = new System.Windows.Forms.Label();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.bookingPanels.SuspendLayout();
            this.innerHeaderPanel.SuspendLayout();
            this.outerConflictPanel.SuspendLayout();
            this.conflictFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
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
            this.bookingPanels.Controls.Add(this.tabContentPanel, 1, 0);
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
            this.bookingListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bookingListPanel.Location = new System.Drawing.Point(3, 3);
            this.bookingListPanel.Name = "bookingListPanel";
            this.bookingListPanel.Size = new System.Drawing.Size(640, 790);
            this.bookingListPanel.TabIndex = 1;
            this.bookingListPanel.WrapContents = false;
            // 
            // tabContentPanel
            // 
            this.tabContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContentPanel.Location = new System.Drawing.Point(649, 3);
            this.tabContentPanel.Name = "tabContentPanel";
            this.tabContentPanel.Size = new System.Drawing.Size(964, 790);
            this.tabContentPanel.TabIndex = 2;
            // 
            // innerHeaderPanel
            // 
            this.innerHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.BorderRadius = 25;
            this.innerHeaderPanel.Controls.Add(this.refreshBtn);
            this.innerHeaderPanel.Controls.Add(this.clearSearchbarBtn);
            this.innerHeaderPanel.Controls.Add(this.searchBarTextBox);
            this.innerHeaderPanel.Controls.Add(this.dismissedSelected);
            this.innerHeaderPanel.Controls.Add(this.completedSelected);
            this.innerHeaderPanel.Controls.Add(this.completedBtn);
            this.innerHeaderPanel.Controls.Add(this.dismissedBtn);
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
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.refreshBtn.Image = global::ClientManagementSubsystem.Properties.Resources.free_refresh_icon_3104_thumb;
            this.refreshBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.refreshBtn.ImageRotate = 0F;
            this.refreshBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.refreshBtn.Location = new System.Drawing.Point(1175, 71);
            this.refreshBtn.MaximumSize = new System.Drawing.Size(40, 40);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.refreshBtn.Size = new System.Drawing.Size(35, 39);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // clearSearchbarBtn
            // 
            this.clearSearchbarBtn.BackColor = System.Drawing.Color.White;
            this.clearSearchbarBtn.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.clearSearchbarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchbarBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.clearSearchbarBtn.Image = global::ClientManagementSubsystem.Properties.Resources.closeIcon;
            this.clearSearchbarBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.clearSearchbarBtn.ImageRotate = 0F;
            this.clearSearchbarBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.clearSearchbarBtn.Location = new System.Drawing.Point(1546, 68);
            this.clearSearchbarBtn.MaximumSize = new System.Drawing.Size(40, 40);
            this.clearSearchbarBtn.Name = "clearSearchbarBtn";
            this.clearSearchbarBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.clearSearchbarBtn.Size = new System.Drawing.Size(29, 30);
            this.clearSearchbarBtn.TabIndex = 10;
            this.clearSearchbarBtn.Click += new System.EventHandler(this.clearSearchbarBtn_Click);
            // 
            // searchBarTextBox
            // 
            this.searchBarTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBarTextBox.DefaultText = "";
            this.searchBarTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBarTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBarTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTextBox.IconLeft = global::ClientManagementSubsystem.Properties.Resources.search_bar_01;
            this.searchBarTextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.searchBarTextBox.IconRightSize = new System.Drawing.Size(35, 35);
            this.searchBarTextBox.Location = new System.Drawing.Point(1236, 55);
            this.searchBarTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchBarTextBox.Name = "searchBarTextBox";
            this.searchBarTextBox.PlaceholderText = "";
            this.searchBarTextBox.SelectedText = "";
            this.searchBarTextBox.Size = new System.Drawing.Size(349, 55);
            this.searchBarTextBox.TabIndex = 9;
            this.searchBarTextBox.TextChanged += new System.EventHandler(this.searchBarTextBox_TextChanged);
            // 
            // dismissedSelected
            // 
            this.dismissedSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.dismissedSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.dismissedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.dismissedSelected.Location = new System.Drawing.Point(447, 105);
            this.dismissedSelected.Name = "dismissedSelected";
            this.dismissedSelected.PolygonSkip = 1;
            this.dismissedSelected.Rotate = 0F;
            this.dismissedSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.dismissedSelected.Size = new System.Drawing.Size(210, 5);
            this.dismissedSelected.TabIndex = 8;
            this.dismissedSelected.Text = "guna2Shapes2";
            this.dismissedSelected.Zoom = 100;
            // 
            // completedSelected
            // 
            this.completedSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.completedSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.completedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.completedSelected.Location = new System.Drawing.Point(663, 105);
            this.completedSelected.Name = "completedSelected";
            this.completedSelected.PolygonSkip = 1;
            this.completedSelected.Rotate = 0F;
            this.completedSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.completedSelected.Size = new System.Drawing.Size(234, 5);
            this.completedSelected.TabIndex = 7;
            this.completedSelected.Text = "guna2Shapes2";
            this.completedSelected.Zoom = 100;
            // 
            // completedBtn
            // 
            this.completedBtn.BackColor = System.Drawing.Color.Transparent;
            this.completedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completedBtn.DefaultAutoSize = true;
            this.completedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completedBtn.FillColor = System.Drawing.Color.Transparent;
            this.completedBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.completedBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.completedBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.completedBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.completedBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.completedBtn.Location = new System.Drawing.Point(663, 36);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.PressedColor = System.Drawing.Color.Transparent;
            this.completedBtn.Size = new System.Drawing.Size(234, 63);
            this.completedBtn.TabIndex = 5;
            this.completedBtn.Text = "Completed";
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // dismissedBtn
            // 
            this.dismissedBtn.BackColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.BorderColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dismissedBtn.DefaultAutoSize = true;
            this.dismissedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dismissedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dismissedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dismissedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dismissedBtn.FillColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.dismissedBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.dismissedBtn.Location = new System.Drawing.Point(447, 36);
            this.dismissedBtn.Name = "dismissedBtn";
            this.dismissedBtn.PressedColor = System.Drawing.Color.Transparent;
            this.dismissedBtn.Size = new System.Drawing.Size(217, 63);
            this.dismissedBtn.TabIndex = 4;
            this.dismissedBtn.Text = "Dismissed";
            this.dismissedBtn.Click += new System.EventHandler(this.cancelledBtn_Click);
            // 
            // pendingSelected
            // 
            this.pendingSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.pendingSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.Location = new System.Drawing.Point(34, 105);
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
            this.approvedSelected.Location = new System.Drawing.Point(226, 105);
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
            this.approvedBtn.DefaultAutoSize = true;
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
            this.approvedBtn.Location = new System.Drawing.Point(226, 36);
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
            this.pendingBtn.DefaultAutoSize = true;
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
            this.pendingBtn.Location = new System.Drawing.Point(34, 36);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.PressedColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Size = new System.Drawing.Size(186, 63);
            this.pendingBtn.TabIndex = 0;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // customerBdayDTP
            // 
            this.customerBdayDTP.Location = new System.Drawing.Point(0, 0);
            this.customerBdayDTP.Name = "customerBdayDTP";
            this.customerBdayDTP.Size = new System.Drawing.Size(200, 20);
            this.customerBdayDTP.TabIndex = 0;
            // 
            // rentalDateEndDTP
            // 
            this.rentalDateEndDTP.Location = new System.Drawing.Point(0, 0);
            this.rentalDateEndDTP.Name = "rentalDateEndDTP";
            this.rentalDateEndDTP.Size = new System.Drawing.Size(200, 20);
            this.rentalDateEndDTP.TabIndex = 0;
            // 
            // rentalDateStartDTP
            // 
            this.rentalDateStartDTP.Location = new System.Drawing.Point(0, 0);
            this.rentalDateStartDTP.Name = "rentalDateStartDTP";
            this.rentalDateStartDTP.Size = new System.Drawing.Size(200, 20);
            this.rentalDateStartDTP.TabIndex = 0;
            // 
            // lblBookingIDValue
            // 
            this.lblBookingIDValue.Location = new System.Drawing.Point(0, 0);
            this.lblBookingIDValue.Name = "lblBookingIDValue";
            this.lblBookingIDValue.Size = new System.Drawing.Size(100, 23);
            this.lblBookingIDValue.TabIndex = 0;
            // 
            // lblRentalTimeValue
            // 
            this.lblRentalTimeValue.Location = new System.Drawing.Point(0, 0);
            this.lblRentalTimeValue.Name = "lblRentalTimeValue";
            this.lblRentalTimeValue.Size = new System.Drawing.Size(100, 23);
            this.lblRentalTimeValue.TabIndex = 0;
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.Location = new System.Drawing.Point(0, 0);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.Size = new System.Drawing.Size(100, 23);
            this.lblRentalTime.TabIndex = 0;
            // 
            // lblDateofRequestValue
            // 
            this.lblDateofRequestValue.Location = new System.Drawing.Point(0, 0);
            this.lblDateofRequestValue.Name = "lblDateofRequestValue";
            this.lblDateofRequestValue.Size = new System.Drawing.Size(100, 23);
            this.lblDateofRequestValue.TabIndex = 0;
            // 
            // lblDateOfRequest
            // 
            this.lblDateOfRequest.Location = new System.Drawing.Point(0, 0);
            this.lblDateOfRequest.Name = "lblDateOfRequest";
            this.lblDateOfRequest.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfRequest.TabIndex = 0;
            // 
            // lblRentalPeriod
            // 
            this.lblRentalPeriod.Location = new System.Drawing.Point(0, 0);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(100, 23);
            this.lblRentalPeriod.TabIndex = 0;
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerAge.TabIndex = 0;
            // 
            // lblCustomerBirthday
            // 
            this.lblCustomerBirthday.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerBirthday.Name = "lblCustomerBirthday";
            this.lblCustomerBirthday.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerBirthday.TabIndex = 0;
            // 
            // customerContactNumTextBox
            // 
            this.customerContactNumTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerContactNumTextBox.DefaultText = "";
            this.customerContactNumTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerContactNumTextBox.Location = new System.Drawing.Point(0, 0);
            this.customerContactNumTextBox.Name = "customerContactNumTextBox";
            this.customerContactNumTextBox.PlaceholderText = "";
            this.customerContactNumTextBox.SelectedText = "";
            this.customerContactNumTextBox.Size = new System.Drawing.Size(200, 36);
            this.customerContactNumTextBox.TabIndex = 0;
            // 
            // lblCustomerContactNum
            // 
            this.lblCustomerContactNum.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerContactNum.Name = "lblCustomerContactNum";
            this.lblCustomerContactNum.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerContactNum.TabIndex = 0;
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerEmailTextBox.DefaultText = "";
            this.customerEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerEmailTextBox.Location = new System.Drawing.Point(0, 0);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.PlaceholderText = "";
            this.customerEmailTextBox.SelectedText = "";
            this.customerEmailTextBox.Size = new System.Drawing.Size(200, 36);
            this.customerEmailTextBox.TabIndex = 0;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerEmail.TabIndex = 0;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerInfo.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 36);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(0, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 0;
            // 
            // customerLicenseTextBox
            // 
            this.customerLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerLicenseTextBox.DefaultText = "";
            this.customerLicenseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerLicenseTextBox.Location = new System.Drawing.Point(0, 0);
            this.customerLicenseTextBox.Name = "customerLicenseTextBox";
            this.customerLicenseTextBox.PlaceholderText = "";
            this.customerLicenseTextBox.SelectedText = "";
            this.customerLicenseTextBox.Size = new System.Drawing.Size(200, 36);
            this.customerLicenseTextBox.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.bookingsUserControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.bookingPanels.ResumeLayout(false);
            this.innerHeaderPanel.ResumeLayout(false);
            this.innerHeaderPanel.PerformLayout();
            this.outerConflictPanel.ResumeLayout(false);
            this.outerConflictPanel.PerformLayout();
            this.conflictFlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel bookingListPanel;
        private System.Windows.Forms.TableLayoutPanel bookingPanels;
        private System.Windows.Forms.Panel tabContentPanel;
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
        // approve/reject controls moved into PendingTabUserControl
        private System.Windows.Forms.Label lblBookingConflicts;
        private System.Windows.Forms.FlowLayoutPanel conflictFlowPanel;
        private System.Windows.Forms.Label lblNoBookingConflicts;
        private System.Windows.Forms.Panel outerConflictPanel;
        private System.Windows.Forms.DateTimePicker rentalDateStartDTP;
        private System.Windows.Forms.DateTimePicker rentalDateEndDTP;
        private System.Windows.Forms.DateTimePicker customerBdayDTP;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2GradientPanel innerHeaderPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchBarTextBox;
        private Guna.UI2.WinForms.Guna2Shapes dismissedSelected;
        private Guna.UI2.WinForms.Guna2Shapes completedSelected;
        private Guna.UI2.WinForms.Guna2Button completedBtn;
        private Guna.UI2.WinForms.Guna2Button dismissedBtn;
        private Guna.UI2.WinForms.Guna2Shapes pendingSelected;
        private Guna.UI2.WinForms.Guna2Shapes approvedSelected;
        private Guna.UI2.WinForms.Guna2Button approvedBtn;
        private Guna.UI2.WinForms.Guna2Button pendingBtn;
        private Guna.UI2.WinForms.Guna2ImageButton refreshBtn;
        private Guna.UI2.WinForms.Guna2ImageButton clearSearchbarBtn;
    }
}
