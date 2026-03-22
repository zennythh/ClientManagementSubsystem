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
        private DismissedUserControl dismissedTabUC;
        private CompletedUserControl completedTabUC;

        public bookingsUserControl()
        {
            InitializeComponent();
            SetupSearchTimer();
            InitializeTabs();

            //// Default View
            //ShowTab("Pending");
            //bookingListPanel.AutoScroll = false; 
            //bookingListPanel.VerticalScroll.Visible = true;
            //bookingListPanel.VerticalScroll.Enabled = true;
            //bookingListPanel.AutoScroll = true;
        }

        private void bookingsUserControl_Load(object sender, EventArgs e)
        {
            // Now the window handle exists!
            ShowTab("Pending");

            // Force the scrollbar behavior after handle creation
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
            dismissedTabUC = new DismissedUserControl { Dock = DockStyle.Fill, Visible = false };
            completedTabUC = new CompletedUserControl { Dock = DockStyle.Fill, Visible = false };

            // Add them to the container
            tabContentPanel.Controls.AddRange(new Control[] {
        pendingTabUC, approvedTabUC, dismissedTabUC, completedTabUC
    });

            // Wire up data change events so the list refreshes if an action is taken
            pendingTabUC.DataChanged += (s, e) => RefreshActiveTab();
            approvedTabUC.DataChanged += (s, e) => RefreshActiveTab();
            dismissedTabUC.DataChanged  += (s, e) => RefreshActiveTab();
            //completedTabUC.DataChanged += (s, e) => RefreshActiveTab();


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
            dismissedTabUC.Visible = (tabName == "Cancelled");
            completedTabUC.Visible = (tabName == "Completed");

            // 3. Refresh the Shared List Panel
            RefreshActiveTab();
            CenterCards();
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
            bookingListPanel.SuspendLayout();
            bookingListPanel.Controls.Clear();

            if (bookings == null || bookings.Count == 0)
            {
                if (pendingTabUC.Visible) pendingTabUC.ClearDetails();
                else if (approvedTabUC.Visible) approvedTabUC.ClearDetails();
                bookingListPanel.ResumeLayout();
                CenterCards();
                return;
            }

            foreach (var booking in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(booking);
                card.VehicleName = booking.VehicleName;

                card.OnSelect += (s, e) => {
                    BookingCard clickedCard = (BookingCard)s;
                    if (pendingTabUC.Visible) pendingTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (approvedTabUC.Visible) approvedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (dismissedTabUC.Visible) dismissedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    //else if (completedTabUC.Visible) completedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                };

                // Add the card directly. We will handle centering in CenterCards().
                bookingListPanel.Controls.Add(card);
            }

            bookingListPanel.ResumeLayout();
            CenterCards();
        }

        #region Helpers
        private void CenterCards()
        {
            if (!IsHandleCreated || IsDisposed) return;

            BeginInvoke((MethodInvoker)delegate {
                if (bookingListPanel.Controls.Count == 0) return;

                bookingListPanel.SuspendLayout();

                // 1. Calculate usable width once
                int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
                int usableWidth = bookingListPanel.ClientSize.Width;

                // Only subtract scrollbar if it's actually there to avoid the "tilt"
                if (bookingListPanel.VerticalScroll.Visible)
                    usableWidth -= scrollbarWidth;

                foreach (Control card in bookingListPanel.Controls)
                {
                    // 2. Calculate side margin to force center
                    int sideMargin = (usableWidth - card.Width) / 2;

                    // 3. Apply margin (keep vertical margins as they were)
                    card.Margin = new Padding(Math.Max(0, sideMargin), card.Margin.Top, 0, card.Margin.Bottom);
                }

                bookingListPanel.ResumeLayout(true);
            });
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