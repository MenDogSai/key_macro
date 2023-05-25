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
    public partial class StatusForm : Form, IMessageFilter
    {
        public StatusForm()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == Win32.WM_INPUT)
            {
                RawInput raw = Win32.GetDeviceID(m);

                switch (raw.Header.type)
                {
                    case RawInputType.KEYBOARD:
                        keyboardEvent(raw.Keyboard);
                        break;

                    case RawInputType.MOUSE:
                        mouseEvent(raw.Mouse);
                        break;
                }
            }

            return false;
        }
        private void StatusFormLoad(object sender, EventArgs e)
        {
            imeCheckTimer.Enabled = true;
        }
        private void mouseEvent(RawMouse mouse)
        {
            string text = $"{mouse.buttonFlags}, {mouse.rawButtons}, X : {mouse.X}, Y : {mouse.Y}, {mouse.buttonData}";
            inputKeyTextBox.Text = text;
            mousePositionTextBox.Text = $"{Cursor.Position.X}, {Cursor.Position.Y}";
            onMouseButtons(mouse.buttonFlags);
        }
        private void keyboardEvent(RawKeyboard keyboard)
        {
            string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            inputKeyTextBox.Text = text;
            ushort key  = keyboard.vkey;
            string keyStatus = (keyboard.message == Win32.VK_KEY_UP) ? "뗌" : "누름";
            string description = VisualKey.getKeyDescription(key);
            
            if (keyboard.makeCode == 56) { 
                key = Win32.VK_KEY_LALT;
                description = VisualKey.getKeyDescription(VisualKey.getKeyIndex("ALT"));
            }

            if (key == Win32.VK_KEY_LALT)
                onALT(keyboard.message);
            else
            if (key == Win32.VK_KEY_LCTRL || key == Win32.VK_KEY_RCTRL) { 
                onCTRL(keyboard.message);
                description = VisualKey.getKeyDescription(VisualKey.getKeyIndex("CTL"));
            }
            else
            if (key == Win32.VK_KEY_SHIFT)
                onShift(keyboard.message);
            //inputKeyTextBox.Text = description + " - " + keyStatus;
        }
        private void onMouseButtons(RawMouseButtons buttons)
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
        private void onALT(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                altLabel.Image = Properties.Resources.lamp_off;
            else
                altLabel.Image = Properties.Resources.lamp_on;
        }
        private void onCTRL(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                ctrlLabel.Image = Properties.Resources.lamp_off;
            else
                ctrlLabel.Image = Properties.Resources.lamp_on;
        }
        private void onShift(uint message)
        {
            if (message == Win32.VK_KEY_UP)
                shiftLabel.Image = Properties.Resources.lamp_off;
            else
                shiftLabel.Image = Properties.Resources.lamp_on;
        }
        private void imeCheckTimerTick(object sender, EventArgs e)
        {
            imeCheckTimer.Enabled = false;
            bool checkHangul = Win32.isIMEStatus();
            if (checkHangul)
                languageTextBox.Text = "한글";
            else
                languageTextBox.Text = "영어";
            imeCheckTimer.Enabled  = true;
        }
    }
}
