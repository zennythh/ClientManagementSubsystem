using FontAwesome.Sharp;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Buttons
        private IconButton currentBtn;
        private Color hoverColor = Color.FromArgb(255, 56, 189, 248);
        private Color defaultColor = Color.FromArgb(255, 230, 241, 247);

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
            }
            currentBtn = (IconButton)senderBtn;
            currentBtn.ForeColor = hoverColor;
            currentBtn.IconColor = hoverColor;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = defaultColor;
                currentBtn.IconColor = defaultColor;
            }
        }

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            if (sender is IconButton btn)
            {
                btn.ForeColor = hoverColor;
                btn.IconColor = hoverColor;
            }
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            if (sender is IconButton btn)
            {
                btn.ForeColor = defaultColor;
                btn.IconColor = defaultColor;
            }
        }


        // Methods to display the selected user control in the container panel   
        private void showControl(Control addevent)
        {
            containerPanel.Controls.Clear();
            addevent.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(addevent);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardUserControl uc = new dashboardUserControl();
            showControl(uc);
            ActivateButton(sender);
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            bookingsUserControl uc = new bookingsUserControl();
            showControl(uc);
            ActivateButton(sender);
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            personalUserControl uc = new personalUserControl();
            showControl(uc);
            ActivateButton(sender);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

    }
}
