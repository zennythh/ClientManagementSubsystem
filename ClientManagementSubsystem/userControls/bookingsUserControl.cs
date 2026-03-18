using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementSubsystem
{
    public partial class bookingsUserControl : UserControl
    {
        DatabaseManager db = new DatabaseManager();

        public bookingsUserControl()
        {
            InitializeComponent();
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
            LoadBookingCards();
            // LoadBookings();
        }

        private void LoadBookingCards()
        {
            try
            {
                // 1. Fetch data for 'Pending' status (or change as needed for other panels)
                List<Booking> bookings = db.GetBookingsByStatus("Pending");

                // 2. Clear existing cards to prevent stacking on refresh
                bookingListPanel.Controls.Clear();

                // 3. Loop through the list and create cards
                foreach (Booking booking in bookings)
                {
                    BookingCard card = new BookingCard();

                    // This calls the Populate method we just finished!
                    card.Populate(booking);

                    // Set the VehicleName explicitly if your Populate method doesn't do it yet
                    card.VehicleName = booking.VehicleName;

                    // Subscribe to the select event if you want to open details on click
                    card.OnSelect += (s, e) => {
                        OpenBookingDetails(booking);
                    };

                    bookingListPanel.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private void OpenBookingDetails(Booking b)
        {
            // This is where you would show the full info for the Inbound process
            Console.WriteLine($"Selected Booking #{b.BookingID} for {b.FullName}");
        }

        public void LoadBookings()
        {
            bookingListPanel.Controls.Clear();
            bookingListPanel.SuspendLayout();

            for (int i = 0; i < 12; i++)
            {
                BookingCard card = new BookingCard();

                card.VehicleName = "Toyota Vios";
                card.ClientName = "John Doe";
                card.BookingID = i;
                
                card.OnSelect += (s, e) =>
                {
                    MessageBox.Show($"You clicked booking #{card.BookingID}");
                 };

                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }

        private void CenterCards()
        {
            if (bookingListPanel.Controls.Count == 0) return;

            Control firstCard = bookingListPanel.Controls[0];

            int cardFullWidth = firstCard.Width + firstCard.Margin.Horizontal;
            int availableWidth = bookingListPanel.ClientSize.Width - bookingListPanel.Padding.Horizontal;
            int cardsPerRow = availableWidth / cardFullWidth;
            if (cardsPerRow <= 0) cardsPerRow = 1;
            int totalContentWidth = cardsPerRow * cardFullWidth;
            int lateralPadding = (bookingListPanel.ClientSize.Width - totalContentWidth) / 2;

            bookingListPanel.Padding = new Padding(Math.Max(0, lateralPadding), bookingListPanel.Padding.Top, 0, 0);
        }

        // Button clicks
        private void pendingBtn_Click(object sender, EventArgs e)
        {
            pendingSelected.Visible = true;
            approvedSelected.Visible = false;
        }

        private void approvedBtn_Click(object sender, EventArgs e)
        {
            approvedSelected.Visible = true;
            pendingSelected.Visible = false;
        }


    }
}
