namespace ClientManagementSubsystem
{
    partial class dashboardUserControl
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.fleetStatusPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.fleetIcon = new FontAwesome.Sharp.IconPictureBox();
            this.fleetStatusCountLbl = new System.Windows.Forms.Label();
            this.fleetStatusLbl = new System.Windows.Forms.Label();
            this.outboundPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.inboundIcon = new FontAwesome.Sharp.IconPictureBox();
            this.inboundCountLbl = new System.Windows.Forms.Label();
            this.inboundLbl = new System.Windows.Forms.Label();
            this.inboundPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.outboundIcon = new FontAwesome.Sharp.IconPictureBox();
            this.outboundCountLbl = new System.Windows.Forms.Label();
            this.outboundLbl = new System.Windows.Forms.Label();
            this.reviewsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.reviewsIcon = new FontAwesome.Sharp.IconPictureBox();
            this.reviewsCount = new System.Windows.Forms.Label();
            this.reviewsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.fleetStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fleetIcon)).BeginInit();
            this.outboundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboundIcon)).BeginInit();
            this.inboundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundIcon)).BeginInit();
            this.reviewsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1622, 943);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.panel5.Controls.Add(this.fleetStatusPanel);
            this.panel5.Controls.Add(this.outboundPanel);
            this.panel5.Controls.Add(this.inboundPanel);
            this.panel5.Controls.Add(this.reviewsPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1616, 276);
            this.panel5.TabIndex = 1;
            // 
            // fleetStatusPanel
            // 
            this.fleetStatusPanel.BorderRadius = 20;
            this.fleetStatusPanel.Controls.Add(this.fleetIcon);
            this.fleetStatusPanel.Controls.Add(this.fleetStatusCountLbl);
            this.fleetStatusPanel.Controls.Add(this.fleetStatusLbl);
            this.fleetStatusPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.fleetStatusPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.fleetStatusPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.fleetStatusPanel.Location = new System.Drawing.Point(1169, 22);
            this.fleetStatusPanel.Name = "fleetStatusPanel";
            this.fleetStatusPanel.Size = new System.Drawing.Size(328, 232);
            this.fleetStatusPanel.TabIndex = 9;
            // 
            // fleetIcon
            // 
            this.fleetIcon.BackColor = System.Drawing.Color.Transparent;
            this.fleetIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.fleetIcon.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.fleetIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.fleetIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fleetIcon.IconSize = 57;
            this.fleetIcon.Location = new System.Drawing.Point(12, 19);
            this.fleetIcon.Name = "fleetIcon";
            this.fleetIcon.Size = new System.Drawing.Size(58, 57);
            this.fleetIcon.TabIndex = 2;
            this.fleetIcon.TabStop = false;
            // 
            // fleetStatusCountLbl
            // 
            this.fleetStatusCountLbl.AutoSize = true;
            this.fleetStatusCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.fleetStatusCountLbl.Font = new System.Drawing.Font("Segoe UI", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fleetStatusCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.fleetStatusCountLbl.Location = new System.Drawing.Point(52, 130);
            this.fleetStatusCountLbl.Name = "fleetStatusCountLbl";
            this.fleetStatusCountLbl.Size = new System.Drawing.Size(276, 96);
            this.fleetStatusCountLbl.TabIndex = 1;
            this.fleetStatusCountLbl.Text = "24 / 24";
            // 
            // fleetStatusLbl
            // 
            this.fleetStatusLbl.AllowDrop = true;
            this.fleetStatusLbl.AutoSize = true;
            this.fleetStatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.fleetStatusLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fleetStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.fleetStatusLbl.Location = new System.Drawing.Point(76, 27);
            this.fleetStatusLbl.Name = "fleetStatusLbl";
            this.fleetStatusLbl.Size = new System.Drawing.Size(243, 40);
            this.fleetStatusLbl.TabIndex = 0;
            this.fleetStatusLbl.Text = "Fleet Availability";
            this.fleetStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outboundPanel
            // 
            this.outboundPanel.BorderRadius = 20;
            this.outboundPanel.Controls.Add(this.inboundIcon);
            this.outboundPanel.Controls.Add(this.inboundCountLbl);
            this.outboundPanel.Controls.Add(this.inboundLbl);
            this.outboundPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.outboundPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(224)))));
            this.outboundPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.outboundPanel.Location = new System.Drawing.Point(822, 22);
            this.outboundPanel.Name = "outboundPanel";
            this.outboundPanel.Size = new System.Drawing.Size(328, 232);
            this.outboundPanel.TabIndex = 8;
            // 
            // inboundIcon
            // 
            this.inboundIcon.BackColor = System.Drawing.Color.Transparent;
            this.inboundIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.inboundIcon.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.inboundIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.inboundIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inboundIcon.IconSize = 57;
            this.inboundIcon.Location = new System.Drawing.Point(12, 19);
            this.inboundIcon.Name = "inboundIcon";
            this.inboundIcon.Size = new System.Drawing.Size(58, 57);
            this.inboundIcon.TabIndex = 2;
            this.inboundIcon.TabStop = false;
            // 
            // inboundCountLbl
            // 
            this.inboundCountLbl.AutoSize = true;
            this.inboundCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.inboundCountLbl.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.inboundCountLbl.Location = new System.Drawing.Point(164, 104);
            this.inboundCountLbl.Name = "inboundCountLbl";
            this.inboundCountLbl.Size = new System.Drawing.Size(164, 128);
            this.inboundCountLbl.TabIndex = 1;
            this.inboundCountLbl.Text = "24";
            // 
            // inboundLbl
            // 
            this.inboundLbl.AllowDrop = true;
            this.inboundLbl.AutoSize = true;
            this.inboundLbl.BackColor = System.Drawing.Color.Transparent;
            this.inboundLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboundLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.inboundLbl.Location = new System.Drawing.Point(76, 27);
            this.inboundLbl.Name = "inboundLbl";
            this.inboundLbl.Size = new System.Drawing.Size(235, 40);
            this.inboundLbl.TabIndex = 0;
            this.inboundLbl.Text = "Today\'s Returns";
            this.inboundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inboundPanel
            // 
            this.inboundPanel.BorderRadius = 20;
            this.inboundPanel.Controls.Add(this.outboundIcon);
            this.inboundPanel.Controls.Add(this.outboundCountLbl);
            this.inboundPanel.Controls.Add(this.outboundLbl);
            this.inboundPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.inboundPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.inboundPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.inboundPanel.Location = new System.Drawing.Point(473, 22);
            this.inboundPanel.Name = "inboundPanel";
            this.inboundPanel.Size = new System.Drawing.Size(328, 232);
            this.inboundPanel.TabIndex = 7;
            // 
            // outboundIcon
            // 
            this.outboundIcon.BackColor = System.Drawing.Color.Transparent;
            this.outboundIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.outboundIcon.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.outboundIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.outboundIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.outboundIcon.IconSize = 57;
            this.outboundIcon.Location = new System.Drawing.Point(12, 19);
            this.outboundIcon.Name = "outboundIcon";
            this.outboundIcon.Size = new System.Drawing.Size(58, 57);
            this.outboundIcon.TabIndex = 2;
            this.outboundIcon.TabStop = false;
            // 
            // outboundCountLbl
            // 
            this.outboundCountLbl.AutoSize = true;
            this.outboundCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.outboundCountLbl.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.outboundCountLbl.Location = new System.Drawing.Point(164, 104);
            this.outboundCountLbl.Name = "outboundCountLbl";
            this.outboundCountLbl.Size = new System.Drawing.Size(164, 128);
            this.outboundCountLbl.TabIndex = 1;
            this.outboundCountLbl.Text = "24";
            // 
            // outboundLbl
            // 
            this.outboundLbl.AllowDrop = true;
            this.outboundLbl.AutoSize = true;
            this.outboundLbl.BackColor = System.Drawing.Color.Transparent;
            this.outboundLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboundLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.outboundLbl.Location = new System.Drawing.Point(76, 27);
            this.outboundLbl.Name = "outboundLbl";
            this.outboundLbl.Size = new System.Drawing.Size(234, 40);
            this.outboundLbl.TabIndex = 0;
            this.outboundLbl.Text = "Today\'s Pickups";
            this.outboundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reviewsPanel
            // 
            this.reviewsPanel.BorderRadius = 20;
            this.reviewsPanel.Controls.Add(this.reviewsIcon);
            this.reviewsPanel.Controls.Add(this.reviewsCount);
            this.reviewsPanel.Controls.Add(this.reviewsLabel);
            this.reviewsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.reviewsPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.reviewsPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.reviewsPanel.Location = new System.Drawing.Point(119, 22);
            this.reviewsPanel.Name = "reviewsPanel";
            this.reviewsPanel.Size = new System.Drawing.Size(328, 232);
            this.reviewsPanel.TabIndex = 2;
            // 
            // reviewsIcon
            // 
            this.reviewsIcon.BackColor = System.Drawing.Color.Transparent;
            this.reviewsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.reviewsIcon.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.reviewsIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.reviewsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reviewsIcon.IconSize = 57;
            this.reviewsIcon.Location = new System.Drawing.Point(12, 19);
            this.reviewsIcon.Name = "reviewsIcon";
            this.reviewsIcon.Size = new System.Drawing.Size(58, 57);
            this.reviewsIcon.TabIndex = 2;
            this.reviewsIcon.TabStop = false;
            // 
            // reviewsCount
            // 
            this.reviewsCount.AutoSize = true;
            this.reviewsCount.BackColor = System.Drawing.Color.Transparent;
            this.reviewsCount.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.reviewsCount.Location = new System.Drawing.Point(164, 104);
            this.reviewsCount.Name = "reviewsCount";
            this.reviewsCount.Size = new System.Drawing.Size(164, 128);
            this.reviewsCount.TabIndex = 1;
            this.reviewsCount.Text = "24";
            // 
            // reviewsLabel
            // 
            this.reviewsLabel.AllowDrop = true;
            this.reviewsLabel.AutoSize = true;
            this.reviewsLabel.BackColor = System.Drawing.Color.Transparent;
            this.reviewsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.reviewsLabel.Location = new System.Drawing.Point(76, 27);
            this.reviewsLabel.Name = "reviewsLabel";
            this.reviewsLabel.Size = new System.Drawing.Size(248, 40);
            this.reviewsLabel.TabIndex = 0;
            this.reviewsLabel.Text = "Pending Reviews";
            this.reviewsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "dashboardUserControl";
            this.Size = new System.Drawing.Size(1622, 943);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.fleetStatusPanel.ResumeLayout(false);
            this.fleetStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fleetIcon)).EndInit();
            this.outboundPanel.ResumeLayout(false);
            this.outboundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboundIcon)).EndInit();
            this.inboundPanel.ResumeLayout(false);
            this.inboundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundIcon)).EndInit();
            this.reviewsPanel.ResumeLayout(false);
            this.reviewsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label reviewsLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel reviewsPanel;
        private System.Windows.Forms.Label reviewsCount;
        private FontAwesome.Sharp.IconPictureBox reviewsIcon;
        private Guna.UI2.WinForms.Guna2GradientPanel inboundPanel;
        private FontAwesome.Sharp.IconPictureBox outboundIcon;
        private System.Windows.Forms.Label outboundCountLbl;
        private System.Windows.Forms.Label outboundLbl;
        private Guna.UI2.WinForms.Guna2GradientPanel fleetStatusPanel;
        private FontAwesome.Sharp.IconPictureBox fleetIcon;
        private System.Windows.Forms.Label fleetStatusCountLbl;
        private System.Windows.Forms.Label fleetStatusLbl;
        private Guna.UI2.WinForms.Guna2GradientPanel outboundPanel;
        private FontAwesome.Sharp.IconPictureBox inboundIcon;
        private System.Windows.Forms.Label inboundCountLbl;
        private System.Windows.Forms.Label inboundLbl;
    }
}
