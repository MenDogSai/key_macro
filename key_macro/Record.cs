using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key_macro
{
    public class MouseBlock
    {
        INPUT input;
        public MouseBlock(Point point)
        {
            Point temp = Win32.screenToMousePosition(point);
            input.type = Win32.INPUT_MOUSE;
            input.mi.dx = temp.X;
            input.mi.dy = temp.Y;
            input.mi.dwFlags = MOUSEEVENTF.MOUSEEVENTF_MOVE | MOUSEEVENTF.MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE;
            input.mi.dwExtraInfo = IntPtr.Zero;
        }
        public MouseBlock(RawMouse mouse, Point point)
        {
            if (point.X < 0 && point.Y < 0)
                point = Cursor.Position;
            Point temp = Win32.screenToMousePosition(point);

            input.type = Win32.INPUT_MOUSE;
            input.mi.dwExtraInfo = IntPtr.Zero;
            input.mi.dx = temp.X;
            input.mi.dy = temp.Y;
            input.mi.dwFlags   = MOUSEEVENTF.MOUSEEVENTF_MOVE | MOUSEEVENTF.MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE;
            input.mi.dwFlags  |= getMouseFlag(mouse.buttonFlags);
            input.mi.mouseData = getMouseData(mouse.buttonFlags, mouse.buttonData);
        }
        void act()
        {
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        private MOUSEEVENTF getMouseFlag(RawMouseButtons buttons)
        {
            switch (buttons)
            {
                case RawMouseButtons.LEFT_UP:
                    return MOUSEEVENTF.MOUSEEVENTF_LEFTUP;
                case RawMouseButtons.LEFT_DOWN:
                    return MOUSEEVENTF.MOUSEEVENTF_LEFTDOWN;
                case RawMouseButtons.RIGHT_UP:
                    return MOUSEEVENTF.MOUSEEVENTF_RIGHTUP;
                case RawMouseButtons.RIGHT_DOWN:
                    return MOUSEEVENTF.MOUSEEVENTF_RIGHTDOWN;
                case RawMouseButtons.MIDDLE_UP:
                    return MOUSEEVENTF.MOUSEEVENTF_MIDDLEUP;
                case RawMouseButtons.MIDDLE_DOWN:
                    return MOUSEEVENTF.MOUSEEVENTF_MIDDLEDOWN;
                case RawMouseButtons.BUTTON4_UP:
                    return MOUSEEVENTF.MOUSEEVENTF_XUP;
                case RawMouseButtons.BUTTON4_DOWN:
                    return MOUSEEVENTF.MOUSEEVENTF_XDOWN;
                case RawMouseButtons.BUTTON5_UP:
                    return MOUSEEVENTF.MOUSEEVENTF_XUP;
                case RawMouseButtons.BUTTON5_DOWN:
                    return MOUSEEVENTF.MOUSEEVENTF_XDOWN;
                case RawMouseButtons.MOUSE_WHELL:
                    return MOUSEEVENTF.MOUSEEVENTF_WHEEL;
            }
            return MOUSEEVENTF.NONE;
        }
        private int getMouseData(RawMouseButtons buttons, ushort buttonData)
        {
            const int XBUTTON1 = 1;
            const int XBUTTON2 = 2;
            switch (buttons)
            {
                case RawMouseButtons.BUTTON4_UP:
                    return XBUTTON1;
                case RawMouseButtons.BUTTON4_DOWN:
                    return XBUTTON1;
                case RawMouseButtons.BUTTON5_UP:
                    return XBUTTON2;
                case RawMouseButtons.BUTTON5_DOWN:
                    return XBUTTON2;
                case RawMouseButtons.MOUSE_WHELL:
                    return (int)buttonData;
            }
            return 0;
        }
    }
    public class KeyBoardBlock
    {
        const uint PRESSED = 1;
        INPUT input;

        public KeyBoardBlock(RawKeyboard keyboard)
        {
            input.ki.wVk = keyboard.vkey;
            input.ki.wScan = keyboard.makeCode;
            input.ki.dwFlags = (keyboard.message & PRESSED) * 2;
            input.ki.dwExtraInfo = IntPtr.Zero;
        }
        void act()
        {
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
    }
    public class WaitBlock
    {
        uint time;
        uint flag;
        public WaitBlock(uint time, uint flag)
        {
            this.time = time;
            this.flag = flag;
        }
        void act(ref uint time)
        {
            this.time = time;
        }
    }
    public class LoopBlock
    {
        uint start;
        uint end;
        uint flag;
        void act()
        {

        }
    }
    public enum BlockName
    {
        NONE_BLOCK = 0,
        MOUSE_BLOCK = 1,
        KEYBOARD_BLOCK = 2,
        WAIT_BLOCK = 3,
        LOOP_BLOCK = 4,
    }
    public class MacroBlock
    {
        public MouseBlock mouse = null;
        public KeyBoardBlock keyBoard = null;
        public WaitBlock wait = null;
        public LoopBlock loop = null;
        public MacroBlock(MacroBlock macroBlock)
        {
            this.mouse = macroBlock.mouse;
            this.keyBoard = macroBlock.keyBoard;
            this.wait = macroBlock.wait;
            this.loop = macroBlock.loop;
        }
        public MacroBlock(MouseBlock mouse)
        {
            this.mouse = mouse;
        }
        public MacroBlock (KeyBoardBlock keyBoard) 
        {
            this.keyBoard = keyBoard;
        }
        public MacroBlock(WaitBlock wait) 
        {
            this.wait = wait;
        }
        public MacroBlock(LoopBlock loop) 
        {
            this.loop = loop;
        }
    }
    public class Record
    {
        int runIndex = 0;
        public List<MacroBlock> blocks = new List<MacroBlock>();
        public Record()
        {

        }
        public void add(MouseBlock mouse)
        {
            blocks.Add(new MacroBlock(mouse));
        }
        public void add(KeyBoardBlock keyBoard)
        {
            blocks.Add(new MacroBlock(keyBoard));
        }
        public void add(WaitBlock wait)
        {
            blocks.Add(new MacroBlock(wait));
        }
        public void add(LoopBlock loop)
        {
            blocks.Add(new MacroBlock(loop));
        }
        public void clear()
        {
            blocks.Clear();
        }
    }
}
