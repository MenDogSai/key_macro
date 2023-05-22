using key_macro.FormList;
using Key_macro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_macro
{
    public partial class MainForm : Form
    {
        private StatusForm statusForm = null;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        public MainForm()
        {
            InitializeComponent();
            VisualKeys.initialize();
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
                MessageBox.Show("RegisterRawInputDevices no work");

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void exitButtonClick(object sender, EventArgs e)
        {
           this.Dispose();
        }

        private void statusButtonClick(object sender, EventArgs e)
        {
            //상태 창 중복 show 방지
            if (statusForm != null) return;

            statusForm = new StatusForm();
            statusForm.FormClosed += new FormClosedEventHandler(statusFormClosed);
            statusForm.Show();

        }
        private void statusFormClosed(object sender, FormClosedEventArgs e)
        {
            statusForm = null;
        }
    }
}
