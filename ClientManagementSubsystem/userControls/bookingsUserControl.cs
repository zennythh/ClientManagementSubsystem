using ClientManagementSubsystem.classes;
using ClientManagementSubsystem.models;
using ClientManagementSubsystem.Models;
using ClientManagementSubsystem.userControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClientManagementSubsystem
{
    public partial class bookingsUserControl : UserControl
    {
        private Timer searchDebounceTimer;
        private BookingHandler db = new BookingHandler();

        // Tab UserControls
        private PendingTabUserControl pendingTabUC;
        // private ApprovedTabUserControl approvedTabUC; // Placeholder for your next tab

        public bookingsUserControl()
        {
            InitializeComponent();
            SetupSearchTimer();
            InitializeTabs();

            // Default View
            ShowTab("Pending");
        }

        private void InitializeTabs()
        {
            pendingTabUC = new PendingTabUserControl();
            pendingTabUC.Dock = DockStyle.Fill;
            // The designer places the details container in `bookingDetailsPanel`.
            // Add the Pending tab content (details view) into that panel so the
            // parent retains ownership of the bookingListPanel and search logic.
            tabContentPanel.Controls.Add(pendingTabUC);

            // When the child notifies that data changed (approve/reject), refresh list
            pendingTabUC.DataChanged += (s, e) => RefreshActiveTab();

            // if (approvedTabUC == null) { ... }
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
        private void SetupSearchTimer()
        {
            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350;
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
        }

        private void ShowTab(string tabName)
        {
            // Update UI Indicators first
            pendingSelected.Visible = (tabName == "Pending");
            approvedSelected.Visible = (tabName == "Approved");

            // Handle Visibility and initial data load
            if (tabName == "Pending")
            {
                pendingTabUC.Visible = true;
                pendingTabUC.BringToFront();

                // Instead of LoadData(), we use the Search logic with the current text
                // This ensures if there's text in the search bar, the tab opens filtered
                RefreshActiveTab();
            }
            else if (tabName == "Approved")
            {
                pendingTabUC.Visible = false;
                // approvedTabUC.Visible = true;
                // RefreshActiveTab();
            }
        }

        // Single point of truth for refreshing whatever is on screen
        private void RefreshActiveTab()
        {
            string term = searchBarTextBox.Text.Trim();

            try
            {
                List<Booking> bookings;
                if (string.IsNullOrWhiteSpace(term))
                    bookings = db.GetBookingsByStatus("Pending");
                else
                    bookings = db.SearchBookings(term, "Pending");

                PopulateBookingList(bookings);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing list: " + ex.Message);
            }
            // else if (approvedTabUC.Visible) { approvedTabUC.RefreshList(term); }
        }

        private void PopulateBookingList(List<Booking> bookings)
        {
            bookingListPanel.Controls.Clear();

            if (bookings == null || bookings.Count == 0)
            {
                // Clear details if no bookings
                pendingTabUC.ClearDetails();
                return;
            }

            foreach (var booking in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(booking);
                card.VehicleName = booking.VehicleName;

                card.OnSelect += (s, e) => {
                    BookingCard clickedCard = (BookingCard)s;
                    pendingTabUC.DisplayBookingDetails(clickedCard.BookingData);
                };

                bookingListPanel.Controls.Add(card);
            }
            CenterCards();
        }

        #region Search Logic & Debounce Check
        private void searchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            // This is handled correctly: restart the timer on every keystroke
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private void SearchDebounceTimer_Tick(object sender, EventArgs e)
        {
            searchDebounceTimer.Stop();
            RefreshActiveTab();
        }
        #endregion


        #region Navigation Buttons
        private void pendingBtn_Click(object sender, EventArgs e) => ShowTab("Pending");
        private void approvedBtn_Click(object sender, EventArgs e) => ShowTab("Approved");

        // Event handling is owned by the active tab UserControl (PendingTabUserControl).
        // No forwarding stubs are required here.
        #endregion
    }
}