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
        Win32 inputDevice = null;
        public StatusForm()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            inputDevice = new Win32();
        }
        public bool PreFilterMessage(ref Message m)
        {

            if (m.Msg == Win32.WM_INPUT)
            {
                RawInput raw = inputDevice.GetDeviceID(m);

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
        private void mouseEvent(RawMouse mouse)
        {
            string text = $"{mouse.buttonFlags}, {mouse.rawButtons}, X : {mouse.X}, Y : {mouse.Y}, {mouse.buttonData}";
            mousePositionTextBox.Text = $"{Cursor.Position.X}, {Cursor.Position.Y}";
        }
        private void keyboardEvent(RawKeyboard keyboard)
        {
            string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            inputKeyTextBox.Text = text ;
            ushort key = keyboard.vkey;
            if (key == Win32.VK_KEY_LALT || key == Win32.VK_KEY_RALT)
                onALT(keyboard.message);
            else
            if (key == Win32.VK_KEY_LCTRL || key == Win32.VK_KEY_RCTRL)
                onCTRL(keyboard.message);
            else
            if (key == Win32.VK_KEY_SHIFT)
                onShift(keyboard.message);
        }
        private void onALT(uint message)
        {
            message &= Win32.VK_KEY_UP;
            if (message == Win32.VK_KEY_DOWN)
                altLabel.Image = Properties.Resources.lamp_on;
            else
                altLabel.Image = Properties.Resources.lamp_off;
        }
        private void onCTRL(uint message)
        {
            if (message == Win32.VK_KEY_DOWN)
                ctrlLabel.Image = Properties.Resources.lamp_on;
            else
                ctrlLabel.Image = Properties.Resources.lamp_off;
        }
        private void onShift(uint message)
        {
            if (message == Win32.VK_KEY_DOWN)
                shiftLabel.Image = Properties.Resources.lamp_on;
            else
                shiftLabel.Image = Properties.Resources.lamp_off;
        }
    }
}
