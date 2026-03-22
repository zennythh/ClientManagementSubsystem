namespace ClientManagementSubsystem.userControls
{
    partial class BookingCard
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cardPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblTimeAgo = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblBookingNum = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.guna2ShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPanel
            // 
            this.cardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardPanel.Controls.Add(this.lblTo);
            this.cardPanel.Controls.Add(this.lblTimeAgo);
            this.cardPanel.Controls.Add(this.lblDateOut);
            this.cardPanel.Controls.Add(this.lblDateIn);
            this.cardPanel.Controls.Add(this.lblBooking);
            this.cardPanel.Controls.Add(this.lblBookingNum);
            this.cardPanel.Controls.Add(this.lblClient);
            this.cardPanel.Controls.Add(this.lblVehicle);
            this.cardPanel.FillColor = System.Drawing.Color.White;
            this.cardPanel.Location = new System.Drawing.Point(0, 0);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Radius = 10;
            this.cardPanel.ShadowColor = System.Drawing.Color.Black;
            this.cardPanel.Size = new System.Drawing.Size(587, 139);
            this.cardPanel.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(488, 54);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 30);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "to";
            // 
            // lblTimeAgo
            // 
            this.lblTimeAgo.AutoSize = true;
            this.lblTimeAgo.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAgo.Location = new System.Drawing.Point(316, 24);
            this.lblTimeAgo.Name = "lblTimeAgo";
            this.lblTimeAgo.Size = new System.Drawing.Size(180, 30);
            this.lblTimeAgo.TabIndex = 7;
            this.lblTimeAgo.Text = "DATE SUBMITTED";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOut.Location = new System.Drawing.Point(316, 54);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(111, 30);
            this.lblDateOut.TabIndex = 6;
            this.lblDateOut.Text = "DATE OUT";
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIn.Location = new System.Drawing.Point(316, 84);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(92, 30);
            this.lblDateIn.TabIndex = 5;
            this.lblDateIn.Text = "DATE IN";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(27, 24);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(137, 30);
            this.lblBooking.TabIndex = 4;
            this.lblBooking.Text = "BOOKING ID:";
            // 
            // lblBookingNum
            // 
            this.lblBookingNum.AutoSize = true;
            this.lblBookingNum.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNum.Location = new System.Drawing.Point(164, 24);
            this.lblBookingNum.Name = "lblBookingNum";
            this.lblBookingNum.Size = new System.Drawing.Size(0, 30);
            this.lblBookingNum.TabIndex = 2;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(27, 54);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 30);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "CLIENT";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(27, 84);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(92, 30);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "VEHICLE";
            // 
            // BookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "BookingCard";
            this.Size = new System.Drawing.Size(587, 139);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardPanel;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm2;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblBookingNum;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTimeAgo;
    }
}
