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
    public partial class RecordForm : Form, IMessageFilter
    {
        uint recordTime = 0;
        bool recordEnable = false;
        Record record = new Record();
        public RecordForm()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }
        public bool PreFilterMessage(ref Message msg)
        {
            if (msg.Msg == Win32.WM_INPUT)
            {
                RawInput raw = Win32.GetDeviceID(msg);

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
        private void recordButtonClick(object sender, EventArgs e)
        {
            if (recordEnable) { 
                recordEnable = false;
                recordTimer.Enabled = false;
            }
            else { 
                recordEnable = true;
                recordTimer.Enabled = true;
            }
        }
        private void mouseEvent(RawMouse mouse)
        {
            string text = $"{mouse.buttonFlags}, {mouse.rawButtons}, {mouse.buttonData}";
            testLabel.Text = text;
            if (!recordEnable) return;
            recordTimer.Enabled = false;
            MouseBlock mouseBlock = null;

            WaitBlock waitBlock = new WaitBlock(recordTime, 0);
            record.add(waitBlock);
            if (mouse.buttonFlags == 0)
                mouseBlock = new MouseBlock(Cursor.Position);
            else
                mouseBlock = new MouseBlock(mouse, Cursor.Position);

            record.add(mouseBlock);

            recordListBox.Items.Add(waitBlock.description);
            recordListBox.Items.Add(mouseBlock.description);
            recordTime = 0;
            recordTimer.Enabled = true;
        }
        private void keyboardEvent(RawKeyboard keyboard)
        {
            string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            testLabel.Text = text;
            if (!recordEnable) return;

            WaitBlock waitBlock = new WaitBlock(recordTime, 0);
            record.add(waitBlock);
            KeyBoardBlock keyBoardBlock = new KeyBoardBlock(keyboard);
            record.add(keyBoardBlock);

            recordListBox.Items.Add(waitBlock.description);
            recordListBox.Items.Add(keyBoardBlock.description);
            recordTime = 0;
            recordTimer.Enabled = true;
        }
        private void okButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void cancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void recordTimerTick(object sender, EventArgs e)
        {
            recordTimer.Enabled = true;
            recordTime += 1;
            recordTimer.Enabled = false;
        }
    }
}
