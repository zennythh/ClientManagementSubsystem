namespace ClientManagementSubsystem.userControls
{
    partial class ConflictBookingCard
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
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRentalStartDate = new System.Windows.Forms.Label();
            this.lblRentalEndDate = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblTimeAgo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(62, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(121, 25);
            this.lblBooking.TabIndex = 6;
            this.lblBooking.Text = "BOOKING ID:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(158, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(52, 25);
            this.lblBookingID.TabIndex = 5;
            this.lblBookingID.Text = "3242";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(65, 25);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "NAME";
            // 
            // lblRentalStartDate
            // 
            this.lblRentalStartDate.AutoSize = true;
            this.lblRentalStartDate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalStartDate.Location = new System.Drawing.Point(3, 50);
            this.lblRentalStartDate.Name = "lblRentalStartDate";
            this.lblRentalStartDate.Size = new System.Drawing.Size(115, 25);
            this.lblRentalStartDate.TabIndex = 8;
            this.lblRentalStartDate.Text = "START DATE";
            // 
            // lblRentalEndDate
            // 
            this.lblRentalEndDate.AutoSize = true;
            this.lblRentalEndDate.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalEndDate.Location = new System.Drawing.Point(3, 75);
            this.lblRentalEndDate.Name = "lblRentalEndDate";
            this.lblRentalEndDate.Size = new System.Drawing.Size(99, 25);
            this.lblRentalEndDate.TabIndex = 9;
            this.lblRentalEndDate.Text = "END DATE";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(145, 50);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 25);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "to";
            // 
            // lblTimeAgo
            // 
            this.lblTimeAgo.AutoSize = true;
            this.lblTimeAgo.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAgo.Location = new System.Drawing.Point(158, 25);
            this.lblTimeAgo.Name = "lblTimeAgo";
            this.lblTimeAgo.Size = new System.Drawing.Size(93, 25);
            this.lblTimeAgo.TabIndex = 11;
            this.lblTimeAgo.Text = "TIMEAGO";
            // 
            // ConflictBookingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTimeAgo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblRentalEndDate);
            this.Controls.Add(this.lblRentalStartDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblBookingID);
            this.Name = "ConflictBookingCard";
            this.Size = new System.Drawing.Size(271, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRentalStartDate;
        private System.Windows.Forms.Label lblRentalEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblTimeAgo;
    }
}
