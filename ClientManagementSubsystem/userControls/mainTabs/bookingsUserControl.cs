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
                // Clear whatever details panel is currently visible
                if (pendingTabUC.Visible) pendingTabUC.ClearDetails();
                else if (approvedTabUC.Visible) approvedTabUC.ClearDetails();
                bookingListPanel.ResumeLayout();
                CenterCards();
                return;
            }

            // Use a wrapper panel per card so we can center fixed-width cards reliably inside the vertical flow
            foreach (var booking in bookings)
            {
                BookingCard card = new BookingCard();
                card.Populate(booking);
                card.VehicleName = booking.VehicleName;

                card.OnSelect += (s, e) => {
                    BookingCard clickedCard = (BookingCard)s;

                    if (pendingTabUC.Visible)
                        pendingTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (approvedTabUC.Visible)
                        approvedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (dismissedTabUC.Visible)
                        dismissedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                    else if (completedTabUC.Visible)
                        dismissedTabUC.DisplayBookingDetails(clickedCard.BookingData);
                };

                // Create a transparent wrapper the full available width so the card can be centered inside it
                Panel wrapper = new Panel();
                wrapper.BackColor = Color.Transparent;
                wrapper.AutoSize = false;

                // Calculate available width immediately (account for possible scrollbar and panel padding)
                int availableWidth = bookingListPanel.ClientSize.Width - bookingListPanel.Padding.Left - bookingListPanel.Padding.Right;
                try { if (bookingListPanel.VerticalScroll.Visible) availableWidth -= SystemInformation.VerticalScrollBarWidth; } catch { }
                wrapper.Width = Math.Max(availableWidth, card.Width);

                // Height should include the card height plus its vertical margins
                int verticalMargins = card.Margin.Top + card.Margin.Bottom;
                wrapper.Height = card.Height + verticalMargins;

                // Preserve vertical margins by applying them to the wrapper and clear card margins
                wrapper.Margin = new Padding(0, card.Margin.Top, 0, card.Margin.Bottom);
                card.Margin = new Padding(0);

                // Place the card centered inside the wrapper
                card.Location = new Point(Math.Max(0, (wrapper.ClientSize.Width - card.Width) / 2), 0);

                // Ensure the card won't auto-dock or anchor to the wrapper edges
                card.Anchor = AnchorStyles.None;

                wrapper.Controls.Add(card);
                bookingListPanel.Controls.Add(wrapper);
            }
            CenterCards();
        }

        #region Helpers
        private void CenterCards()
        {
            if (!IsHandleCreated || IsDisposed) return;

            // Offload to UI thread if required and adjust margins so each card is centered
            BeginInvoke((MethodInvoker)delegate {
                if (bookingListPanel.Controls.Count == 0) return;

                bookingListPanel.SuspendLayout();

                // When a vertical scrollbar is visible the effective width for controls is reduced.
                int effectiveWidth = bookingListPanel.ClientSize.Width;
                try
                {
                    if (bookingListPanel.VerticalScroll.Visible)
                    {
                        effectiveWidth -= SystemInformation.VerticalScrollBarWidth;
                    }
                }
                catch
                {
                    // ignore if property not available during layout
                }

                foreach (Control card in bookingListPanel.Controls)
                {
                    // If this control is a wrapper panel (we create wrappers when adding cards),
                    // resize it to the available width and center its child inside.
                    if (card is Panel wrapper)
                    {
                        // Preserve vertical margins, reset horizontal margins
                        int top = wrapper.Margin.Top;
                        int bottom = wrapper.Margin.Bottom;
                        wrapper.Margin = new Padding(0, top, 0, bottom);

                        // Update wrapper width to fill available space so scrollbar changes don't shift layout
                        wrapper.Width = Math.Max(effectiveWidth, wrapper.Width);

                        // Center any child control(s) horizontally inside the wrapper
                        foreach (Control child in wrapper.Controls)
                        {
                            child.Anchor = AnchorStyles.None;
                            child.Location = new Point(Math.Max(0, (wrapper.ClientSize.Width - child.Width) / 2), Math.Max(0, child.Location.Y));
                        }
                    }
                    else
                    {
                        // Fallback for plain controls: center by setting symmetric horizontal margins
                        card.Anchor = AnchorStyles.None;
                        int sideMargin = Math.Max(0, (effectiveWidth - card.Width) / 2);
                        card.Margin = new Padding(sideMargin, card.Margin.Top, sideMargin, card.Margin.Bottom);
                    }
                }

                // Reset horizontal padding to avoid additional offset
                bookingListPanel.Padding = new Padding(0, bookingListPanel.Padding.Top, 0, bookingListPanel.Padding.Bottom);

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