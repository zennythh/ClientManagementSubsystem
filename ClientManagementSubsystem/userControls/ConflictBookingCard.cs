using ClientManagementSubsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagementSubsystem.classes;

namespace ClientManagementSubsystem.userControls
{
    public partial class ConflictBookingCard : UserControl
    {
        public ConflictBookingCard()
        {
            InitializeComponent();
        }

        public void Populate(Booking b)
        {
            lblBookingID.Text = b.BookingID.ToString();
            lblCustomerName.Text = b.FullName;

            lblRentalStartDate.Text = b.DateSchedOut.ToString("MM/dd/yyyy hh:mm tt");
            lblRentalEndDate.Text = b.DateDue.ToString("MM/dd/yyyy hh:mm tt");
            lblTimeAgo.Text = b.DateSubmitted.ToTimeAgoMinimal();

            // UI Polish
            this.BackColor = Color.FromArgb(255, 235, 235); // Very light red
        }
    }
}
