namespace ClientManagementSubsystem
{
    partial class Homepage
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.bookingsBtn = new FontAwesome.Sharp.IconButton();
            this.personalBtn = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Panel1.Controls.Add(this.personalBtn);
            this.guna2Panel1.Controls.Add(this.bookingsBtn);
            this.guna2Panel1.Controls.Add(this.dashboardBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 467);
            this.guna2Panel1.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.Black;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(3, 3);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(194, 71);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.bookingsBtn.IconColor = System.Drawing.Color.Black;
            this.bookingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.Location = new System.Drawing.Point(3, 80);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Size = new System.Drawing.Size(194, 71);
            this.bookingsBtn.TabIndex = 2;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            // 
            // personalBtn
            // 
            this.personalBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personalBtn.FlatAppearance.BorderSize = 0;
            this.personalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.personalBtn.IconColor = System.Drawing.Color.Black;
            this.personalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.Location = new System.Drawing.Point(3, 157);
            this.personalBtn.Name = "personalBtn";
            this.personalBtn.Size = new System.Drawing.Size(194, 71);
            this.personalBtn.TabIndex = 3;
            this.personalBtn.Text = "Agent Stats";
            this.personalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personalBtn.UseVisualStyleBackColor = false;
            this.personalBtn.Click += new System.EventHandler(this.personalBtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 544);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Homepage";
            this.RightToLeftLayout = true;
            this.Text = "Client Management";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton personalBtn;
        private FontAwesome.Sharp.IconButton bookingsBtn;
    }
}

