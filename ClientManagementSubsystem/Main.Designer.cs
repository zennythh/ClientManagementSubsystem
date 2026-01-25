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
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.personalBtn = new FontAwesome.Sharp.IconButton();
            this.bookingsBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.containerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.sidebarPanel.Controls.Add(this.logoutBtn);
            this.sidebarPanel.Controls.Add(this.personalBtn);
            this.sidebarPanel.Controls.Add(this.bookingsBtn);
            this.sidebarPanel.Controls.Add(this.dashboardBtn);
            this.sidebarPanel.Location = new System.Drawing.Point(-1, 85);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(213, 463);
            this.sidebarPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logoutBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 30;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logoutBtn.Location = new System.Drawing.Point(13, 405);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(112, 42);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.logoutBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // personalBtn
            // 
            this.personalBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personalBtn.FlatAppearance.BorderSize = 0;
            this.personalBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.personalBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.personalBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.personalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.Location = new System.Drawing.Point(0, 157);
            this.personalBtn.Name = "personalBtn";
            this.personalBtn.Size = new System.Drawing.Size(221, 71);
            this.personalBtn.TabIndex = 3;
            this.personalBtn.Text = "Agent Stats";
            this.personalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personalBtn.UseVisualStyleBackColor = false;
            this.personalBtn.Click += new System.EventHandler(this.personalBtn_Click);
            this.personalBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.personalBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.bookingsBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.bookingsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.bookingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.Location = new System.Drawing.Point(0, 80);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Size = new System.Drawing.Size(221, 71);
            this.bookingsBtn.TabIndex = 2;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            this.bookingsBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.bookingsBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 3);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(221, 71);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            this.dashboardBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.dashboardBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.containerPanel.Location = new System.Drawing.Point(218, 63);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(808, 485);
            this.containerPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.headerPanel.Controls.Add(this.welcomeLabel);
            this.headerPanel.Location = new System.Drawing.Point(218, -6);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(801, 52);
            this.headerPanel.TabIndex = 3;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(188, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Logged in as {Username}";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.logoPanel.Location = new System.Drawing.Point(-1, -1);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(213, 87);
            this.logoPanel.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1019, 544);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.Text = "Client Management";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton personalBtn;
        private FontAwesome.Sharp.IconButton bookingsBtn;
        private Guna.UI2.WinForms.Guna2Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Panel logoPanel;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

