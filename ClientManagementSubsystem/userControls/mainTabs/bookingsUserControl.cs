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
        private PendingUserControl pendingTabUC;
        private ApprovedUserControl approvedTabUC;
        private DismissedUserControl cancelledTabUC;
        private CompletedUserControl completedTabUC;

        public bookingsUserControl()
        {
            InitializeComponent();
            SetupSearchTimer();
            InitializeTabs();

            // Default View
            ShowTab("Pending");
            bookingListPanel.AutoScroll = false; 
            bookingListPanel.VerticalScroll.Visible = true;
            bookingListPanel.VerticalScroll.Enabled = true;
            bookingListPanel.AutoScroll = true;
        }

        private void InitializeTabs()
        {
            // Initialize all tabs
            pendingTabUC = new PendingUserControl { Dock = DockStyle.Fill, Visible = false };
            approvedTabUC = new ApprovedUserControl { Dock = DockStyle.Fill, Visible = false };
            cancelledTabUC = new DismissedUserControl { Dock = DockStyle.Fill, Visible = false };
            completedTabUC = new CompletedUserControl { Dock = DockStyle.Fill, Visible = false };

            // Add them to the container
            tabContentPanel.Controls.AddRange(new Control[] {
        pendingTabUC, approvedTabUC, cancelledTabUC, completedTabUC
    });

            // Wire up data change events so the list refreshes if an action is taken
            pendingTabUC.DataChanged += (s, e) => RefreshActiveTab();
            approvedTabUC.DataChanged += (s, e) => RefreshActiveTab();

            bookingListPanel.Resize += (s, e) => CenterCards();
        }

        private void ShowTab(string tabName)
        {
            // 1. Update Indicator Visibility
            pendingSelected.Visible = (tabName == "Pending");
            approvedSelected.Visible = (tabName == "Approved");
            dismissedSelected.Visible = (tabName == "Cancelled");
            completedSelected.Visible = (tabName == "Completed");

            // 2. Update Detail Panel Visibility
            pendingTabUC.Visible = (tabName == "Pending");
            approvedTabUC.Visible = (tabName == "Approved");
            cancelledTabUC.Visible = (tabName == "Cancelled");
            completedTabUC.Visible = (tabName == "Completed");

            // 3. Refresh the Shared List Panel
            RefreshActiveTab();
        }

        // Single point of truth for refreshing whatever is on screen
        private void RefreshActiveTab()
        {
            string term = searchBarTextBox.Text.Trim();
            string dbStatus = "";

            // Map UI Tabs to Database Status Values
            if (pendingSelected.Visible) dbStatus = "Pending";
            else if (approvedSelected.Visible) dbStatus = "Reserved"; // Your DB use "Reserved"
            else if (dismissedSelected.Visible) dbStatus = "Rejected"; // Your DB uses "Rejected"
            else if (completedSelected.Visible) dbStatus = "Completed";

            if (string.IsNullOrEmpty(dbStatus)) return;

            try
            {
                List<Booking> bookings;
                if (string.IsNullOrWhiteSpace(term))
                    bookings = db.GetBookingsByStatus(dbStatus);
                else
                    bookings = db.SearchBookings(term, dbStatus);

                PopulateBookingList(bookings);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing list: " + ex.Message);
            }
        }

        private void PopulateBookingList(List<Booking> bookings)
        {
            bookingListPanel.Controls.Clear();

            if (bookings == null || bookings.Count == 0)
            {
                // Clear whatever details panel is currently visible
                if (pendingTabUC.Visible) pendingTabUC.ClearDetails();
                else if (approvedTabUC.Visible) approvedTabUC.ClearDetails();
                return;
            }

            foreach (var booking in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(booking);
                card.VehicleName = booking.VehicleName;

                card.OnSelect += (s, e) => {
                    BookingCard clickedCard = (BookingCard)s;

                    // Send data to the ACTIVE details tab
                    // Remove the brackets above when uncommenting the other tabs, they are just there to prevent compile errors until those tabs are implemented.
                    if (pendingTabUC.Visible)
                        pendingTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (approvedTabUC.Visible) 
                        approvedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (cancelledTabUC.Visible) { }
                        //cancelledTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (completedTabUC.Visible) { }
                        //completedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                };

                bookingListPanel.Controls.Add(card);
            }
            CenterCards();
        }

        #region Helpers
        private void CenterCards()
        {
            if (bookingListPanel.Controls.Count == 0) return;

            // Force a layout logic update to ensure ClientSize is accurate
            bookingListPanel.PerformLayout();

            Control firstCard = bookingListPanel.Controls[0];
            int cardFullWidth = firstCard.Width + firstCard.Margin.Horizontal;

            // Subtract a small buffer (e.g., 25px) to account for the potential scrollbar 
            // so the layout doesn't change when the scrollbar appears.
            int availableWidth = bookingListPanel.ClientSize.Width - bookingListPanel.Padding.Horizontal - 20;

            int cardsPerRow = availableWidth / cardFullWidth;
            if (cardsPerRow <= 0) cardsPerRow = 1;

            int totalContentWidth = cardsPerRow * cardFullWidth;
            int lateralPadding = (bookingListPanel.ClientSize.Width - totalContentWidth) / 2;

            // Reset padding but keep the Top padding you might have set in Designer
            bookingListPanel.Padding = new Padding(Math.Max(0, lateralPadding), bookingListPanel.Padding.Top, 0, 0);
        }

        private void SetupSearchTimer()
        {
            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350;
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
        }
        #endregion

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
        private void cancelledBtn_Click(object sender, EventArgs e) => ShowTab("Cancelled");
        private void completedBtn_Click(object sender, EventArgs e) => ShowTab("Completed");

        // Event handling is owned by the active tab UserControl (PendingTabUserControl).
        // No forwarding stubs are required here.
        #endregion

        private void clearSearchbarBtn_Click(object sender, EventArgs e)
        {
            searchBarTextBox.Clear();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshActiveTab();
        }
    }
}