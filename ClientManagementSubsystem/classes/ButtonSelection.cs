using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms; // Ensure this namespace is present for Guna2Shapes

namespace ClientManagementSubsystem
{
    public class ButtonSelection
    {
        private IconButton currentBtn;
        private readonly Color _activeColor;
        private readonly Color _defaultColor;

        // Dictionary to link buttons to their indicator shapes
        private Dictionary<IconButton, Guna2Panel> _indicators = new Dictionary<IconButton, Guna2Panel>();

        public ButtonSelection(Color activeColor, Color defaultColor)
        {
            _activeColor = activeColor;
            _defaultColor = defaultColor;
        }

        // Linking the buttons with their indicator shapes
        public void RegisterButton(IconButton btn, Guna2Panel indicator)
        {
            if (!_indicators.ContainsKey(btn))
            {
                _indicators.Add(btn, indicator);
                // Ensure all indicators start as hidden
                indicator.Visible = false;
            }
        }

        public void ActivateButton(object senderBtn)
        {
            if (senderBtn is IconButton btn)
            {
                DisableButton();

                currentBtn = btn;
                currentBtn.ForeColor = _activeColor;
                currentBtn.IconColor = _activeColor;
                currentBtn.IconSize = 52;

                if (_indicators.ContainsKey(currentBtn))
                {
                    _indicators[currentBtn].Visible = true;
                }
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = _defaultColor;
                currentBtn.IconColor = _defaultColor;
                currentBtn.IconSize = 45;

                if (_indicators.ContainsKey(currentBtn))
                {
                    _indicators[currentBtn].Visible = false;
                }
            }
        }

        public void OnMouseEnter(object sender)
        {
            if (sender is IconButton btn)
            {
                btn.ForeColor = _activeColor;
                btn.IconColor = _activeColor;
            }
        }

        public void OnMouseLeave(object sender)
        {
            if (sender is IconButton btn && btn != currentBtn)
            {
                btn.ForeColor = _defaultColor;
                btn.IconColor = _defaultColor;
            }
        }
    }
}