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
                        OnKeyboardEvent(raw.Keyboard);
                        break;

                    case RawInputType.MOUSE:
                        OnMouseEvent(raw.Mouse);
                        break;
                }
            }

            return false;
        }
        void OnMouseEvent(RawMouse mouse)
        {
            string text = $"{mouse.buttonFlags}, {mouse.rawButtons}, X : {mouse.X}, Y : {mouse.Y}, {mouse.buttonData}";
            mousePositionTextBox.Text = $"{Cursor.Position.X}, {Cursor.Position.Y}";
        }
        void OnKeyboardEvent(RawKeyboard keyboard)
        {
            string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            inputKeyTextBox.Text = text ;
        }
    }
}
