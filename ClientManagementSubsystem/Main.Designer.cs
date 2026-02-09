namespace ClientManagementSubsystem
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.containerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.activityLabel = new System.Windows.Forms.Label();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.bookingsBtn = new FontAwesome.Sharp.IconButton();
            this.personalBtn = new FontAwesome.Sharp.IconButton();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.outboundBtn = new FontAwesome.Sharp.IconButton();
            this.damagesBtn = new FontAwesome.Sharp.IconButton();
            this.inboundBtn = new FontAwesome.Sharp.IconButton();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dashboardSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.bookingsSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.outboundSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.inboundSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.damagesSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.personalSelected = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.containerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 105);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1996, 1209);
            this.containerPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.headerPanel.Controls.Add(this.logoutBtn);
            this.headerPanel.Controls.Add(this.activityLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1996, 105);
            this.headerPanel.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.logoutBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 60;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(1541, 0);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(455, 105);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Agent Name";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.BackColor = System.Drawing.Color.Transparent;
            this.activityLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.activityLabel.Location = new System.Drawing.Point(28, 34);
            this.activityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(232, 55);
            this.activityLabel.TabIndex = 0;
            this.activityLabel.Text = "Dashboard";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Gray;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 45;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 156);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(330, 120);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.ForeColor = System.Drawing.Color.Gray;
            this.bookingsBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.bookingsBtn.IconColor = System.Drawing.Color.DarkGray;
            this.bookingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingsBtn.IconSize = 45;
            this.bookingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.Location = new System.Drawing.Point(0, 272);
            this.bookingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookingsBtn.Size = new System.Drawing.Size(330, 120);
            this.bookingsBtn.TabIndex = 2;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsBtn.UseVisualStyleBackColor = true;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            // 
            // personalBtn
            // 
            this.personalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personalBtn.FlatAppearance.BorderSize = 0;
            this.personalBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.personalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBtn.ForeColor = System.Drawing.Color.Gray;
            this.personalBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.personalBtn.IconColor = System.Drawing.Color.DarkGray;
            this.personalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personalBtn.IconSize = 45;
            this.personalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.Location = new System.Drawing.Point(0, 732);
            this.personalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.personalBtn.Name = "personalBtn";
            this.personalBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.personalBtn.Size = new System.Drawing.Size(330, 120);
            this.personalBtn.TabIndex = 3;
            this.personalBtn.Text = "Agent History";
            this.personalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personalBtn.UseVisualStyleBackColor = true;
            this.personalBtn.Click += new System.EventHandler(this.personalBtn_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.White;
            this.sidebarPanel.BorderRadius = 15;
            this.sidebarPanel.Controls.Add(this.personalSelected);
            this.sidebarPanel.Controls.Add(this.damagesSelected);
            this.sidebarPanel.Controls.Add(this.inboundSelected);
            this.sidebarPanel.Controls.Add(this.outboundSelected);
            this.sidebarPanel.Controls.Add(this.bookingsSelected);
            this.sidebarPanel.Controls.Add(this.dashboardSelected);
            this.sidebarPanel.Controls.Add(this.outboundBtn);
            this.sidebarPanel.Controls.Add(this.damagesBtn);
            this.sidebarPanel.Controls.Add(this.inboundBtn);
            this.sidebarPanel.Controls.Add(this.personalBtn);
            this.sidebarPanel.Controls.Add(this.bookingsBtn);
            this.sidebarPanel.Controls.Add(this.dashboardBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(326, 1322);
            this.sidebarPanel.TabIndex = 1;
            // 
            // outboundBtn
            // 
            this.outboundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outboundBtn.BackColor = System.Drawing.Color.Transparent;
            this.outboundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.outboundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outboundBtn.FlatAppearance.BorderSize = 0;
            this.outboundBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.outboundBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.outboundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.outboundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outboundBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundBtn.ForeColor = System.Drawing.Color.Gray;
            this.outboundBtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.outboundBtn.IconColor = System.Drawing.Color.DarkGray;
            this.outboundBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.outboundBtn.IconSize = 45;
            this.outboundBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outboundBtn.Location = new System.Drawing.Point(0, 386);
            this.outboundBtn.Margin = new System.Windows.Forms.Padding(0);
            this.outboundBtn.Name = "outboundBtn";
            this.outboundBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.outboundBtn.Size = new System.Drawing.Size(330, 120);
            this.outboundBtn.TabIndex = 6;
            this.outboundBtn.Text = "Outbound";
            this.outboundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.outboundBtn.UseVisualStyleBackColor = true;
            this.outboundBtn.Click += new System.EventHandler(this.outboundBtn_Click);
            // 
            // damagesBtn
            // 
            this.damagesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.damagesBtn.BackColor = System.Drawing.Color.Transparent;
            this.damagesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.damagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.damagesBtn.FlatAppearance.BorderSize = 0;
            this.damagesBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.damagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.damagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.damagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damagesBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damagesBtn.ForeColor = System.Drawing.Color.Gray;
            this.damagesBtn.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.damagesBtn.IconColor = System.Drawing.Color.DarkGray;
            this.damagesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.damagesBtn.IconSize = 45;
            this.damagesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.damagesBtn.Location = new System.Drawing.Point(0, 616);
            this.damagesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.damagesBtn.Name = "damagesBtn";
            this.damagesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.damagesBtn.Size = new System.Drawing.Size(330, 117);
            this.damagesBtn.TabIndex = 5;
            this.damagesBtn.Text = "Damages";
            this.damagesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.damagesBtn.UseVisualStyleBackColor = true;
            this.damagesBtn.Click += new System.EventHandler(this.damagesBtn_Click);
            // 
            // inboundBtn
            // 
            this.inboundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inboundBtn.BackColor = System.Drawing.Color.Transparent;
            this.inboundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inboundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inboundBtn.FlatAppearance.BorderSize = 0;
            this.inboundBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.inboundBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inboundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.inboundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboundBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundBtn.ForeColor = System.Drawing.Color.Gray;
            this.inboundBtn.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.inboundBtn.IconColor = System.Drawing.Color.DarkGray;
            this.inboundBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inboundBtn.IconSize = 45;
            this.inboundBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inboundBtn.Location = new System.Drawing.Point(0, 501);
            this.inboundBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inboundBtn.Name = "inboundBtn";
            this.inboundBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inboundBtn.Size = new System.Drawing.Size(330, 123);
            this.inboundBtn.TabIndex = 4;
            this.inboundBtn.Text = "Inbound";
            this.inboundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inboundBtn.UseVisualStyleBackColor = true;
            this.inboundBtn.Click += new System.EventHandler(this.inboundBtn_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.White;
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.layoutPanel.Controls.Add(this.sidebarPanel, 0, 0);
            this.layoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(2330, 1322);
            this.layoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.containerPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(330, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1996, 1314);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dashboardSelected
            // 
            this.dashboardSelected.BackColor = System.Drawing.Color.Transparent;
            this.dashboardSelected.BorderRadius = 15;
            this.dashboardSelected.CustomizableEdges.BottomLeft = false;
            this.dashboardSelected.CustomizableEdges.TopLeft = false;
            this.dashboardSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.dashboardSelected.Location = new System.Drawing.Point(0, 156);
            this.dashboardSelected.Name = "dashboardSelected";
            this.dashboardSelected.Size = new System.Drawing.Size(14, 120);
            this.dashboardSelected.TabIndex = 0;
            // 
            // bookingsSelected
            // 
            this.bookingsSelected.BackColor = System.Drawing.Color.Transparent;
            this.bookingsSelected.BorderRadius = 15;
            this.bookingsSelected.CustomizableEdges.BottomLeft = false;
            this.bookingsSelected.CustomizableEdges.TopLeft = false;
            this.bookingsSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.bookingsSelected.Location = new System.Drawing.Point(0, 272);
            this.bookingsSelected.Name = "bookingsSelected";
            this.bookingsSelected.Size = new System.Drawing.Size(14, 120);
            this.bookingsSelected.TabIndex = 7;
            // 
            // outboundSelected
            // 
            this.outboundSelected.BackColor = System.Drawing.Color.Transparent;
            this.outboundSelected.BorderRadius = 15;
            this.outboundSelected.CustomizableEdges.BottomLeft = false;
            this.outboundSelected.CustomizableEdges.TopLeft = false;
            this.outboundSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.outboundSelected.Location = new System.Drawing.Point(0, 386);
            this.outboundSelected.Name = "outboundSelected";
            this.outboundSelected.Size = new System.Drawing.Size(14, 120);
            this.outboundSelected.TabIndex = 8;
            // 
            // inboundSelected
            // 
            this.inboundSelected.BackColor = System.Drawing.Color.Transparent;
            this.inboundSelected.BorderRadius = 15;
            this.inboundSelected.CustomizableEdges.BottomLeft = false;
            this.inboundSelected.CustomizableEdges.TopLeft = false;
            this.inboundSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.inboundSelected.Location = new System.Drawing.Point(0, 501);
            this.inboundSelected.Name = "inboundSelected";
            this.inboundSelected.Size = new System.Drawing.Size(14, 120);
            this.inboundSelected.TabIndex = 9;
            // 
            // damagesSelected
            // 
            this.damagesSelected.BackColor = System.Drawing.Color.Transparent;
            this.damagesSelected.BorderRadius = 15;
            this.damagesSelected.CustomizableEdges.BottomLeft = false;
            this.damagesSelected.CustomizableEdges.TopLeft = false;
            this.damagesSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.damagesSelected.Location = new System.Drawing.Point(0, 613);
            this.damagesSelected.Name = "damagesSelected";
            this.damagesSelected.Size = new System.Drawing.Size(14, 120);
            this.damagesSelected.TabIndex = 10;
            // 
            // personalSelected
            // 
            this.personalSelected.BackColor = System.Drawing.Color.Transparent;
            this.personalSelected.BorderRadius = 15;
            this.personalSelected.CustomizableEdges.BottomLeft = false;
            this.personalSelected.CustomizableEdges.TopLeft = false;
            this.personalSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.personalSelected.Location = new System.Drawing.Point(0, 732);
            this.personalSelected.Name = "personalSelected";
            this.personalSelected.Size = new System.Drawing.Size(14, 120);
            this.personalSelected.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(2330, 1322);
            this.Controls.Add(this.layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.Text = "Client Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label activityLabel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton bookingsBtn;
        private FontAwesome.Sharp.IconButton personalBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton inboundBtn;
        private FontAwesome.Sharp.IconButton damagesBtn;
        private FontAwesome.Sharp.IconButton outboundBtn;
        private Guna.UI2.WinForms.Guna2Panel dashboardSelected;
        private Guna.UI2.WinForms.Guna2Panel personalSelected;
        private Guna.UI2.WinForms.Guna2Panel damagesSelected;
        private Guna.UI2.WinForms.Guna2Panel inboundSelected;
        private Guna.UI2.WinForms.Guna2Panel outboundSelected;
        private Guna.UI2.WinForms.Guna2Panel bookingsSelected;
    }
}

