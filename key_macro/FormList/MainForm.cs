using key_macro.FormList;
using Key_macro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace key_macro
{
    public partial class MainForm : Form, IMessageFilter
    {
        private StatusForm statusForm = null;
        private RecordForm recordForm = null;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private bool iconCheck = false;
        private readonly List<Record> records = new List<Record>();
        public MainForm()
        {
            InitializeComponent();
            VisualKey.Initialize();
            Application.AddMessageFilter(this);
        }
        private void MainFormLoad(object sender, EventArgs e)
        {
            const int RID_SIZE = 2;
            RAWINPUTDEVICE[] rid = new RAWINPUTDEVICE[RID_SIZE];

            rid[0].usagePage = HIDUsagePage.GENERIC;
            rid[0].usage = HIDUsage.MOUSE;
            rid[0].flags = RawInputDeviceFlags.INPUT_SINK;
            rid[0].windowHandle = Handle;

            rid[1].usagePage = HIDUsagePage.GENERIC;
            rid[1].usage = HIDUsage.KEYBOARD;
            rid[1].flags = RawInputDeviceFlags.INPUT_SINK;
            rid[1].windowHandle = Handle;

            int structSize = sizeof(HIDUsagePage) + sizeof(HIDUsage) + sizeof(RawInputDeviceFlags) + IntPtr.Size;

            if (Win32.RegisterRawInputDevices(rid, RID_SIZE, structSize) == false)
                MessageBox.Show("RegisterRawInputDevices가 동작하지 않습니다");
        }
        // 오버라이드 되어 참조 되지 않음
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CP_NOCLOSE_BUTTON;
                return createParams;
            }
        }
        // 이벤트 발생시 호출 되어 코드상 참조 되지 않음
        public bool PreFilterMessage(ref Message msg)
        {
            if (msg.Msg == Win32.WM_INPUT)
            {
                RawInput raw = Win32.GetDeviceID(msg);

                switch (raw.Header.type)
                {
                    case RawInputType.KEYBOARD:
                        KeyboardEvent(raw.Keyboard);
                        break;

                    case RawInputType.MOUSE:
                        MouseEvent(raw.Mouse);
                        break;
                }
            }
            return false;
        }
        private void ExitButtonClick(object sender, EventArgs e)
        {
           this.Dispose();
        }
        private void StatusButtonClick(object sender, EventArgs e)
        {
            //상태 창 중복 방지
            if (statusForm != null) return;

            statusForm = new StatusForm();
            statusForm.FormClosed += new FormClosedEventHandler(StatusFormClosed);
            statusForm.Show();

        }
        private void StatusFormClosed(object sender, FormClosedEventArgs e)
        {
            statusForm = null;
        }
        private void RunRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (runRadioButton.Checked == false) return;

            pathButton.Enabled = false;
            recordButton.Enabled = false;
            configButton.Enabled = false;
            addButton.Enabled = false;
            editButton.Enabled = false;
            copyButton.Enabled = false;
            deleteButton.Enabled = false;
            debugButton.Enabled = true;
            iconTimer.Enabled = true;
        }
        private void StopRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (stopRadioButton.Checked == false) return;

            pathButton.Enabled = true;
            recordButton.Enabled = true;
            configButton.Enabled = true;
            addButton.Enabled = true;
            editButton.Enabled = true;
            copyButton.Enabled = true;
            deleteButton.Enabled = true;
            debugButton.Enabled = false;
            iconTimer.Enabled = false;
            this.Icon = global::key_macro.Properties.Resources.key_macro_ico;
        }
        private void IconTimerTick(object sender, EventArgs e)
        {
            iconTimer.Enabled = false;
            if (iconCheck) { 
                this.Icon = global::key_macro.Properties.Resources.idr_main_ico;
                iconCheck = false;
            }
            else { 
                this.Icon = global::key_macro.Properties.Resources.key_macro_ico;
                iconCheck = true;
            }
            iconTimer.Enabled = true;
        }
        private void RecordButtonClick(object sender, EventArgs e)
        {
            if (recordForm != null) return;
            recordForm = new RecordForm();
            recordForm.ShowDialog();
            if(recordForm.DialogResult == DialogResult.OK)
            {
                Record record = recordForm.GetRecord();
                recordForm.Dispose();
                recordForm = null;
                if (record.name == "") return;
                int cnt = GetDuplicateNumber("Macro Rec", 1);
                record.name += cnt.ToString();
                records.Add(record);
                macroListBox.Items.Add(record.name);
            }
        }
        private void CopyButtonClick(object sender, EventArgs e)
        {
            int index = macroListBox.SelectedIndex;
            if(index == -1) return;
            Record clone = new Record(records[index])
            {
                name = "Macro Clone. "
            };
            int cnt = GetDuplicateNumber("Macro Clone", 1);
            clone.name += cnt.ToString();
            records.Add(clone);
            macroListBox.Items.Add(clone.name);
        }
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            int index = macroListBox.SelectedIndex;
            if (index == -1) return;
            macroListBox.Items.RemoveAt(index);
            records.RemoveAt(index);
        }
        /// <summary>
        /// List 상자에서 매개변수인 name과 같은 중복인 이름이 있는지 찾는 함수
        /// </summary>
        private int GetDuplicateNumber(String name, int cnt)
        {
            foreach (var item in macroListBox.Items)
            {
                string[] temp = $"{item}".Split('.');
                if (temp.Length != 2) continue;
                if (name != temp[0]) continue;
                if (Convert.ToInt32(temp[1]) == cnt)
                    cnt++;
            }
            return cnt;
        }
        private void MouseEvent(RawMouse mouse)
        {
            statusForm?.MouseEvent(mouse);
            recordForm?.MouseEvent(mouse);
        }
        private void KeyboardEvent(RawKeyboard keyboard)
        {
            statusForm?.KeyboardEvent(keyboard);
            recordForm?.KeyboardEvent(keyboard);
            if (runRadioButton.Checked == false) return;
            int index = macroListBox.SelectedIndex;
            if (index == -1) return;
            if (VisualKey.GetKeyName(keyboard.vkey) == "F2")
            {
                records[index].Run();   
            }else
            if (VisualKey.GetKeyName(keyboard.vkey) == "F3")
            {
                records[index].Stop();
            }
        }
    }//end of MainForm
}

