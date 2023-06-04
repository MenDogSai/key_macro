using Key_macro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_macro.FormList
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }
        private void StatusFormLoad(object sender, EventArgs e)
        {
            imeCheckTimer.Enabled = true;
        }
        public void MouseEvent(RawMouse mouse)
        {
            mousePositionTextBox.Text = $"{Cursor.Position.X}, {Cursor.Position.Y}";
            OnMouseButtons(mouse.buttonFlags);
        }
        public void KeyboardEvent(RawKeyboard keyboard)
        {
            ushort key  = keyboard.vkey;
            string keyStatus = (keyboard.message == Win32.VK_KEY_UP) ? "뗌" : "누름";
            string description = VisualKey.GetKeyDescription(key);
            
            if (keyboard.makeCode == 56) { 
                key = Win32.VK_KEY_LALT;
                description = VisualKey.GetKeyDescription(VisualKey.GetKeyIndex("ALT"));
            }

            if (key == Win32.VK_KEY_LALT)
                OnALT(keyboard.message);
            else
            if (key == Win32.VK_KEY_LCTRL || key == Win32.VK_KEY_RCTRL) { 
                OnCTRL(keyboard.message);
                description = VisualKey.GetKeyDescription(VisualKey.GetKeyIndex("CTL"));
            }
            else
            if (key == Win32.VK_KEY_SHIFT)
                OnShift(keyboard.message);
            inputKeyTextBox.Text = $"{description} → {keyStatus}";
        }
        private void OnMouseButtons(RawMouseButtons buttons)
        {
            switch (buttons)
            {
                case RawMouseButtons.LEFT_UP:
                    leftLabel.Image = Properties.Resources.lamp_off;
                    break; 
                case RawMouseButtons.LEFT_DOWN:
                    leftLabel.Image = Properties.Resources.lamp_on;
                    break;
                case RawMouseButtons.RIGHT_UP:
                    rightLabel.Image = Properties.Resources.lamp_off;
                    break;
                case RawMouseButtons.RIGHT_DOWN:
                    rightLabel.Image = Properties.Resources.lamp_on;
                    break;
                case RawMouseButtons.MIDDLE_UP:
                    middleLabel.Image = Properties.Resources.lamp_off;
                    break;
                case RawMouseButtons.MIDDLE_DOWN:
                    middleLabel.Image= Properties.Resources.lamp_on;
                    break;
                case RawMouseButtons.BUTTON4_UP:
                    x1Label.Image = Properties.Resources.lamp_off;
                    break;
                case RawMouseButtons.BUTTON4_DOWN:
                    x1Label.Image= Properties.Resources.lamp_on;
                    break;
                case RawMouseButtons.BUTTON5_UP:
                    x2Label.Image = Properties.Resources.lamp_off;
                    break;
                case RawMouseButtons.BUTTON5_DOWN:
                    x2Label.Image= Properties.Resources.lamp_on;
                    break;
            }
        }
        private void OnALT(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                altLabel.Image = Properties.Resources.lamp_off;
            else
                altLabel.Image = Properties.Resources.lamp_on;
        }
        private void OnCTRL(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                ctrlLabel.Image = Properties.Resources.lamp_off;
            else
                ctrlLabel.Image = Properties.Resources.lamp_on;
        }
        private void OnShift(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                shiftLabel.Image = Properties.Resources.lamp_off;
            else
                shiftLabel.Image = Properties.Resources.lamp_on;
        }
        private void ImeCheckTimerTick(object sender, EventArgs e)
        {
            imeCheckTimer.Enabled = false;
            bool checkHangul = Win32.IsIMEStatus();
            if (checkHangul)
                languageTextBox.Text = "한글";
            else
                languageTextBox.Text = "영어";
            imeCheckTimer.Enabled  = true;
        }
    }
}
