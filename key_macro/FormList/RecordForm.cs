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
    public partial class RecordForm : Form
    {
        private DateTime recordTime;
        private DateTime beforeTime;
        private long recordTimeTotal;
        private Point previous;
        private readonly Record record = new Record();
        public RecordForm()
        {
            InitializeComponent();
        }
        public void MouseEvent(RawMouse mouse)
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

            AddRecordWait();
            AddRecordMouse(mouse, current);
        }
        public void KeyboardEvent(RawKeyboard keyboard)
        {
            //string text = $"VKey : {keyboard.vkey}, Code : {keyboard.makeCode} Msg: {keyboard.message}";
            if (!startCheckBox.Checked) return;

            AddRecordWait();
            AddRecordKeyboard(keyboard);
        }
        private void AddRecordWait()
        {
            DateTime nowTime = DateTime.Now;
            long overTime = (long)delayUpDown.Value;
            long millisecond = (nowTime.Ticks - beforeTime.Ticks) / 10000;
            if (millisecond < overTime || delayCheckBox.Checked == false) return;
            beforeTime = nowTime;

            WaitBlock waitBlock = new WaitBlock(millisecond);
            record.Add(waitBlock);
            record.Add(waitBlock);
            recordListBox.Items.Add(waitBlock.description);
 
            millisecond = (nowTime.Ticks - recordTime.Ticks) / 10000;
            recordTimeTotal += millisecond;
            recordLabel.Text = $"{recordListBox.Items.Count}개의 항목이 기록 됨 ({recordTimeTotal / 1000}.{recordTimeTotal % 1000} 초)";
        }
        private void AddRecordMouse(RawMouse mouse, Point current)
        {
            MouseBlock mouseBlock;
            if (mouse.buttonFlags == RawMouseButtons.NONE)
                mouseBlock = new MouseBlock(current);
            else
                mouseBlock = new MouseBlock(mouse, current);

            recordListBox.Items.Add(mouseBlock.description);
            record.Add(mouseBlock);

            long millisecond = (DateTime.Now.Ticks - recordTime.Ticks) / 10000;
            recordTimeTotal += millisecond;
            recordLabel.Text = $"{recordListBox.Items.Count}개의 항목이 기록 됨 ({recordTimeTotal / 1000}.{recordTimeTotal % 1000} 초)";
        }
        private void AddRecordKeyboard(RawKeyboard keyboard)
        {
            KeyboardBlock keyboardBlock = new KeyboardBlock(keyboard);
            record.Add(keyboardBlock);
            recordListBox.Items.Add(keyboardBlock.description);

            long millisecond = (DateTime.Now.Ticks - recordTime.Ticks) / 10000;
            recordTimeTotal += millisecond;
            recordLabel.Text = $"{recordListBox.Items.Count}개의 항목이 기록 됨 ({recordTimeTotal / 1000}.{recordTimeTotal % 1000} 초)";
        }
        private void OkButtonClick(object sender, EventArgs e)
        {
            int cnt = (int)countUpDown.Value;
            // 반복 1회면 루프블럭을 추가하지 않는다
            if( cnt != 1)
            {
                LoopBlock loopBlock = new LoopBlock(0, cnt);
                record.Add(loopBlock);
            }
            record.name = "Macro Rec. ";
            this.DialogResult = DialogResult.OK;
            
        }
        private void CancelButtonClick(object sender, EventArgs e)
        {
            record.Clear();
            this.DialogResult = DialogResult.OK;
        }
        private void MouseMoveCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (mouseMoveCheckBox.Checked)
                mouseMoveUpDown.Enabled = true;
            else
                mouseMoveUpDown.Enabled = false;
        }
        private void DelayCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (delayCheckBox.Checked)
                delayUpDown.Enabled = true;
            else
                delayUpDown.Enabled = false;
        }
        private void StartCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (startCheckBox.Checked)
            {
                beforeTime = DateTime.Now;
                previous = Cursor.Position;
                startCheckBox.Text = "매크로 기록중";
                recordTime = DateTime.Now;
            }
            else
                startCheckBox.Text = "기록 대기중";
        }
        private void MouseButtonCheckBoxCheckedChanged(object sender, EventArgs e)
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
