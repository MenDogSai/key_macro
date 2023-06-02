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
        private DateTime beforeTime;
        private Point previous;
        private Record record = new Record();
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
        private void mouseEvent(RawMouse mouse)
        {
            //string text = $"{mouse.buttonFlags}, {mouse.rawButtons}, {mouse.buttonData}";
            if (!startCheckBox.Checked) return;

            Point current = Cursor.Position;
            decimal distance = (decimal)Math.Sqrt((Math.Pow(current.X - previous.X, 2) + Math.Pow(current.Y - previous.Y, 2)));

            RawMouseButtons buttons = mouse.buttonFlags;
            if (buttons == RawMouseButtons.NONE && (distance < mouseMoveUpDown.Value || !mouseMoveCheckBox.Checked)) return;
            if (buttons != RawMouseButtons.NONE && !mouseButtonCheckBox.Checked) return;
            if (buttons == RawMouseButtons.MOUSE_WHELL && !mouseWheelcheckBox.Checked) return;

            previous = current;
            if (buttons != RawMouseButtons.NONE && !includePosCheckBox.Checked)
                current = new Point(-1, -1);

            addRecordWait();
            addRecordMouse(mouse, current);
        }
        private void keyboardEvent(RawKeyboard keyboard)
        {
            //string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            if (!startCheckBox.Checked) return;

            addRecordWait();
            addRecordKeyboard(keyboard);
        }
        private void addRecordWait()
        {
            DateTime nowTime = DateTime.Now;
            long overTime = (long)delayUpDown.Value;
            long millisecond = (nowTime.Ticks - beforeTime.Ticks) / 10000;
            if (millisecond < overTime || delayCheckBox.Checked == false) return;
            beforeTime = nowTime;

            WaitBlock waitBlock = new WaitBlock(millisecond, 0);
            record.add(waitBlock);
            recordListBox.Items.Add(waitBlock.description);
        }
        private void addRecordMouse(RawMouse mouse, Point current)
        {
            MouseBlock mouseBlock = null;
            if (mouse.buttonFlags == RawMouseButtons.NONE)
                mouseBlock = new MouseBlock(current);
            else
                mouseBlock = new MouseBlock(mouse, current);

            recordListBox.Items.Add(mouseBlock.description);
            record.add(mouseBlock);
        }
        private void addRecordKeyboard(RawKeyboard keyboard)
        {
            KeyboardBlock keyboardBlock = new KeyboardBlock(keyboard);
            record.add(keyboardBlock);
            recordListBox.Items.Add(keyboardBlock.description);
        }
        private void okButtonClick(object sender, EventArgs e)
        {
            record.name = "Macro Rec. ";
            this.DialogResult = DialogResult.OK;
        }
        private void cancelButtonClick(object sender, EventArgs e)
        {
            record.clear();
            this.DialogResult = DialogResult.OK;
        }
        private void mouseMoveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (mouseMoveCheckBox.Checked)
                mouseMoveUpDown.Enabled = true;
            else
                mouseMoveUpDown.Enabled = false;
        }
        private void delayCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (delayCheckBox.Checked)
                delayUpDown.Enabled = true;
            else
                delayUpDown.Enabled = false;
        }
        private void startCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (startCheckBox.Checked)
            {
                beforeTime = DateTime.Now;
                previous = Cursor.Position;
                startCheckBox.Text = "매크로 기록중";
            }
            else
                startCheckBox.Text = "기록 대기중";
        }
        private void mouseButtonCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (mouseButtonCheckBox.Checked)
                includePosCheckBox.Enabled = true;
            else
                includePosCheckBox.Enabled = false;
        }
        public Record GetRecord()
        {
            return new Record(record);
        }
    }
}
