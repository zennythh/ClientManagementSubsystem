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
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.guna2ShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.Transparent;
            this.cardPanel.Controls.Add(this.lblBookingID);
            this.cardPanel.Controls.Add(this.lblClient);
            this.cardPanel.Controls.Add(this.lblVehicle);
            this.cardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel.FillColor = System.Drawing.Color.White;
            this.cardPanel.Location = new System.Drawing.Point(0, 0);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Radius = 10;
            this.cardPanel.ShadowColor = System.Drawing.Color.Black;
            this.cardPanel.Size = new System.Drawing.Size(500, 400);
            this.cardPanel.TabIndex = 0;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(32, 113);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(138, 30);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "BOOKING ID ";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(32, 83);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 30);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "CLIENT";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(32, 53);
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
            this.Name = "BookingCard";
            this.Size = new System.Drawing.Size(500, 400);
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
        private System.Windows.Forms.Label lblBookingID;
    }
}
