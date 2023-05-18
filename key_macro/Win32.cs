using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_macro
{
    // https://www.pinvoke.net/default.aspx/Enums/HIDUsagePage.html
    public enum HIDUsagePage : ushort
    {
        ///Undefined Unknown usage page.
        UNDEFINED = 0x00,
        ///Generic desktop controls.
        GENERIC = 0x01, 
        ///Simulation controls.
        SIMULATION = 0x02, 
        ///Virtual reality controls.
        VR = 0x03, 
        ///Sports controls.
        SPORT = 0x04, //Sport
        ///Games controls.
        GAME = 0x05,
        ///Keyboard controls.
        KEYBOARD = 0x07,
        ///LED controls.
        LED = 0x08,
        ///Button.
        BUTTON = 0x09,
        ///Ordinal.
        ORDINAL = 0x0A,
        ///Telephony.
        TELEPHONY = 0x0B,
        ///Consumer.
        CONSUMER = 0x0C,
        ///Digitizer.
        DIGITIZER = 0x0D,
        ///Physical interface device.
        PID = 0x0F,
        ///Unicode.
        UNICODE = 0x10,
        ///Alphanumeric display.
        ALPHA_NUMERIC = 0x14,
        ///Medical instruments.
        MEDICAL = 0x40,
        ///Monitor page 0.
        MONITOR_PAGE0 = 0x80,
        ///Monitor page 1.
        MONITOR_PAGE1 = 0x81,
        ///Monitor page 2.
        MONITOR_PAGE2 = 0x82,
        ///Monitor page 3.
        MONITOR_PAGE3 = 0x83,
        ///Power page 0.
        POWER_PAGE0 = 0x84,
        ///Power page 1.
        POWER_PAGE1 = 0x85,
        ///Power page 2.
        POWER_PAGE2 = 0x86,
        ///Power page 3.
        POWER_PAGE3 = 0x87,
        ///Bar code scanner.
        BARCODE = 0x8C,
        ///Scale page.
        SCALE = 0x8D,
        ///Magnetic strip reading devices.
        MSR = 0x8E
    }

    // https://www.pinvoke.net/default.aspx/Enums/HIDUsage.html
    public enum HIDUsage : ushort
    {
        MOUSE = 0x02,
        KEYBOARD = 0x06,
    }

    // https://www.pinvoke.net/default.aspx/Enums/RawInputDeviceFlags.html
    [Flags()]
    public enum RawInputDeviceFlags
    {
        ///No flags.
        NONE = 0,
        ///If set, this removes the top level collection from the inclusion list. This tells the operating system to stop reading from a device which matches the top level collection.
        REMOVE = 0x00000001,
        ///If set, this specifies the top level collections to exclude when reading a complete usage page. This flag only affects a TLC whose usage page is already specified with PageOnly.
        EXCLUDE = 0x00000010,
        ///If set, this specifies all devices whose top level collection is from the specified usUsagePage. Note that Usage must be zero. To exclude a particular top level collection, use Exclude.
        PAGE_ONLY = 0x00000020,
        ///If set, this prevents any devices specified by UsagePage or Usage from generating legacy messages. This is only for the mouse and keyboard.
        NO_LEGACY = 0x00000030,
        ///If set, this enables the caller to receive the input even when the caller is not in the foreground. Note that WindowHandle must be specified.
        INPUT_SINK = 0x00000100, 
        ///If set, the mouse button click does not activate the other window.
        CAPTURE_MOUSE = 0x00000200, 
        ///If set, the application-defined keyboard device hotkeys are not handled. However, the system hotkeys; for example, ALT+TAB and CTRL+ALT+DEL, are still handled. By default, all keyboard hotkeys are handled. NoHotKeys can be specified even if NoLegacy is not specified and WindowHandle is NULL.
        NO_HOTKEYS = 0x00000200,
        ///If set, application keys are handled.  NoLegacy must be specified.  Keyboard only.
        APPKEYS = 0x00000400
    }

    // https://www.pinvoke.net/default.aspx/Structures.RAWINPUTDEVICE
    [StructLayout(LayoutKind.Sequential)]
    public struct RAWINPUTDEVICE
    {
        ///Top level collection Usage page for the raw input device.
        public HIDUsagePage usagePage;
        ///Top level collection Usage for the raw input device. 
        public HIDUsage usage;
        ///Mode flag that specifies how to interpret the information provided by UsagePage and Usage.
        public RawInputDeviceFlags flags;
        ///Handle to the target device. If NULL, it follows the keyboard focus.
        public IntPtr windowHandle;
    }

    public enum RawInputType
    {
        /// Mouse input.
        MOUSE = 0,
        /// Keyboard input.
        KEYBOARD = 1,
        /// Another device that is not the keyboard or the mouse.
        HID = 2
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        ///Type of device the input is coming from.
        public RawInputType type;
        ///Size of the packet of data.
        public int size;
        ///Handle to the device sending the data.
        public IntPtr device;
        ///wParam from the window message.
        public int param;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort makeCode;
        [MarshalAs(UnmanagedType.U2)]
        public ushort flags;
        [MarshalAs(UnmanagedType.U2)]
        public ushort reserved;
        [MarshalAs(UnmanagedType.U2)]
        public ushort vkey;
        [MarshalAs(UnmanagedType.U4)]
        public uint message;
        [MarshalAs(UnmanagedType.U4)]
        public uint extraInformation;
    }

    [Flags()]
    public enum RawMouseButtons : ushort
    {
        ///No button.
        NONE = 0,
        ///Left (button 1) down.
        LEFT_DOWN = 0x0001,
        ///Left (button 1) up.
        LEFT_UP = 0x0002,
        ///Right (button 2) down.
        RIGHT_DOWN = 0x0004,
        ///Right (button 2) up.
        RIGHT_UP = 0x0008,
        ///Middle (button 3) down.
        MIDDLE_DOWN = 0x0010,
        ///Middle (button 3) up.
        MIDDLE_UP = 0x0020,
        ///Button 4 down.
        BUTTON4_DOWN = 0x0040,
        ///Button 4 up.
        BUTTON4_UP = 0x0080,
        ///Button 5 down.
        BUTTON5_DOWN = 0x0100,
        ///Button 5 up.
        BUTTON5_UP = 0x0200,
        ///Mouse wheel moved.
        MOUSE_WHELL= 0x0400
    }

    [Flags()]
    public enum RawMouseFlags : ushort
    {
        ///Relative to the last position.
        MOVE_RELATIVE = 0,
        ///Absolute positioning.
        MOVE_ABSOLUTE = 1,
        ///Coordinate data is mapped to a virtual desktop.
        VIRTUAL_DESKTOP = 2,
        ///Attributes for the mouse have changed.
        ATTRIBUTES_CHANGED = 4
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RawMouse
    {
        /// The mouse state.
        [FieldOffset(0)]
        public RawMouseFlags flags;
        /// Flags for the event.
        [FieldOffset(4)]
        public RawMouseButtons buttonFlags;
        /// If the mouse wheel is moved, this will contain the delta amount.
        [FieldOffset(6)]
        public ushort buttonData;
        /// Raw button data.
        [FieldOffset(8)]
        public uint rawButtons;
        /// The motion in the X direction. This is signed relative motion or 
        /// absolute motion, depending on the value of usFlags. 
        [FieldOffset(12)]
        public int X;
        /// The motion in the Y direction. This is signed relative motion or absolute motion, 
        /// depending on the value of usFlags. 
        [FieldOffset(16)]
        public int Y;
        /// The device-specific additional information for the event. 
        [FieldOffset(20)]
        public uint extraInformation;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RawInput32
    {
        ///Header for the data.
        [FieldOffset(0)]
        public RawInputHeader header;
        ///Mouse raw input data.
        [FieldOffset(16)]
        public RawMouse mouse;
        ///Keyboard raw input data.
        [FieldOffset(16)]
        public RawKeyboard keyboard;
        ///HID raw input data.
        [FieldOffset(16)]
        public RAWHID hid;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RawInput64
    {
        ///Header for the data.
        [FieldOffset(0)]
        public RawInputHeader header;
        ///Mouse raw input data.
        [FieldOffset(24)]
        public RawMouse mouse;
        ///Keyboard raw input data.
        [FieldOffset(24)]
        public RawKeyboard keyboard;
        ///HID raw input data.
        [FieldOffset(24)]
        public RAWHID hid;
    }

    public class RawInput
    {
        private RawInput64 rawInput64;
        private RawInput32 rawInput32;

        public RawInput(RawInput64 rawObj)
        {
            this.rawInput64 = rawObj;
        }

        public RawInput(RawInput32 rawObj)
        {
            this.rawInput32 = rawObj;
        }

        public RawInputHeader Header
        {
            get
            {
                return (IntPtr.Size == 4) ? rawInput32.header : rawInput64.header;
            }
        }

        public RawMouse Mouse 
        { 
            get
            {
                return (IntPtr.Size == 4) ? rawInput32.mouse : rawInput64.mouse;
            }
        }
        public RawKeyboard Keyboard
        {
            get
            {
                return (IntPtr.Size == 4) ? rawInput32.keyboard : rawInput64.keyboard;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RAWHID
    {
        [MarshalAs(UnmanagedType.U4)]
        public int sizHid;
        [MarshalAs(UnmanagedType.U4)]
        public int count;
    }
    /*
    /// Struct representing a point.
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public static implicit operator Point(POINT point)
        {
            return new Point(point.X, point.Y);
        }
    }*/

    public class Win32
    {
        public const int RID_INPUT = 0x10000003;
        public const int RIDEV_INPUTSINK = 0x00000100;

        public const int WM_INPUT = 0x00FF;
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_PARENTNOTIFY = 0x210;

        public const int RIM_INPUT = 0;
        public const int RIM_INPUTSINK = 1;

        [DllImport("user32.dll")]
        public static extern bool RegisterRawInputDevices([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] RAWINPUTDEVICE[] pRawInputDevices, int uiNumDevices, int cbSize);

        [DllImport("User32.dll")]
        public static extern uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);
        /// Retrieves the cursor's position, in screen coordinates.
        /// <see>See MSDN documentation for further information.</see>
        ///[DllImport("user32.dll")]
        ///public static extern bool GetCursorPos(out POINT lpPoint);

        public RawInput GetDeviceID(Message message)
        {
            uint size = 0;
            uint headerSize = (uint)Marshal.SizeOf(typeof(RawInputHeader));

            Win32.GetRawInputData(message.LParam, Win32.RID_INPUT, IntPtr.Zero, ref size, headerSize);
            IntPtr buffer = Marshal.AllocHGlobal((int)size);
            Win32.GetRawInputData(message.LParam, Win32.RID_INPUT, buffer, ref size, headerSize);

            RawInput rawInput;

            if (IntPtr.Size == 4)
            {
                var rawObject = Marshal.PtrToStructure(buffer, typeof(RawInput32));
                rawInput = new RawInput( (RawInput32)rawObject);
            }
            else
            {
                var rawObject = Marshal.PtrToStructure(buffer, typeof(RawInput64));
                rawInput = new RawInput( (RawInput64)rawObject);  
            }

            Marshal.FreeHGlobal(buffer);

            return rawInput;
        }
        /*
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)
            return lpPoint;
        }*/
    }
}