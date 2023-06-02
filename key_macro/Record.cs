﻿using Key_macro;
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
        public int index;
        public string description;
        private INPUT input;
        public MouseBlock(Point point)
        {
            Point temp = Win32.screenToMousePosition(point);
            input.type = Win32.INPUT_MOUSE;
            input.mi.dx = temp.X;
            input.mi.dy = temp.Y;
            input.mi.dwFlags = MOUSEEVENTF.MOUSEEVENTF_MOVE | MOUSEEVENTF.MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE;
            input.mi.dwExtraInfo = IntPtr.Zero;
            description = $"마우스 [{point.X}, {point.Y}]";
        }
        public MouseBlock(RawMouse mouse, Point point)
        {
            Point temp = point;
            description = "마우스 ";
            if (point.X  > -1 && point.Y > -1) { 
                temp = Win32.screenToMousePosition(point);
                description = $"마우스 [{point.X},{point.Y}] ";
            }
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
            if(input.mi.dx == -1 && input.mi.dy == -1) {
                Point temp = Win32.screenToMousePosition(Cursor.Position);
                input.mi.dx = temp.X;
                input.mi.dy = temp.Y;
            }
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        private MOUSEEVENTF getMouseFlag(RawMouseButtons buttons)
        {
            switch (buttons)
            {
                case RawMouseButtons.LEFT_UP:
                    description += "[왼쪽 버튼] → 누름";
                    return MOUSEEVENTF.MOUSEEVENTF_LEFTUP;

                case RawMouseButtons.LEFT_DOWN:
                    description = "[왼쪽 버튼] → 뗌";
                    return MOUSEEVENTF.MOUSEEVENTF_LEFTDOWN;

                case RawMouseButtons.RIGHT_UP:
                    description = "[오른쪽 버튼] → 누름";
                    return MOUSEEVENTF.MOUSEEVENTF_RIGHTUP;

                case RawMouseButtons.RIGHT_DOWN:
                    description = "[오른쪽 버튼] → 뗌";
                    return MOUSEEVENTF.MOUSEEVENTF_RIGHTDOWN;

                case RawMouseButtons.MIDDLE_UP:
                    description = "[중간 버튼] → 누름";
                    return MOUSEEVENTF.MOUSEEVENTF_MIDDLEUP;

                case RawMouseButtons.MIDDLE_DOWN:
                    description = "[오른쪽 버튼] → 뗌";
                    return MOUSEEVENTF.MOUSEEVENTF_MIDDLEDOWN;

                case RawMouseButtons.BUTTON4_UP:
                    description = "[X1 버튼] → 누름";
                    return MOUSEEVENTF.MOUSEEVENTF_XUP;

                case RawMouseButtons.BUTTON4_DOWN:
                    description = "[X1 버튼] → 뗌";
                    return MOUSEEVENTF.MOUSEEVENTF_XDOWN;

                case RawMouseButtons.BUTTON5_UP:
                    description = "[X2 버튼] → 누름";
                    return MOUSEEVENTF.MOUSEEVENTF_XUP;

                case RawMouseButtons.BUTTON5_DOWN:
                    description = "[X2 버튼] → 뗌";
                    return MOUSEEVENTF.MOUSEEVENTF_XDOWN;

                case RawMouseButtons.MOUSE_WHELL:
                    description = "[휠] → ";
                    return MOUSEEVENTF.MOUSEEVENTF_WHEEL;
            }
            description = "마우스 ";
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
                    description += (buttonData == 120)? "증가": "감소";
                    return (int)buttonData;
            }
            return 0;
        }
    }
    public class KeyboardBlock
    {
        public int index;
        public string description;
        private INPUT input;

        public KeyboardBlock(RawKeyboard keyboard)
        {
            const uint PRESSED = 1;
            input.ki.wVk = keyboard.vkey;
            input.ki.wScan = keyboard.makeCode;
            input.ki.dwFlags = (keyboard.message & PRESSED) * 2;
            input.ki.dwExtraInfo = IntPtr.Zero;
            description = $"키보드 [{VisualKey.getKeyDescription(keyboard.vkey)}] → ";
            description += ((keyboard.message & PRESSED) == 0) ? "누름" : "뗌";
        }
        void act()
        {
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
    }
    public class WaitBlock
    {
        public int index;
        public string description;
        long time;
        uint flag;
        public WaitBlock(long time, uint flag)
        {
            this.time = time;
            this.flag = flag;
            description = $"시간지연 {time/1000}.{time%1000} 초";
        }
        void act(ref long time)
        {
            this.time = time;
        }
    }
    public class LoopBlock
    {
        public int index;
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
        public KeyboardBlock keyboard = null;
        public WaitBlock wait = null;
        public LoopBlock loop = null;
        public MacroBlock(MacroBlock macroBlock)
        {
            this.mouse = macroBlock.mouse;
            this.keyboard = macroBlock.keyboard;
            this.wait = macroBlock.wait;
            this.loop = macroBlock.loop;
        }
        public MacroBlock(MouseBlock mouse)
        {
            this.mouse = mouse;
        }
        public MacroBlock (KeyboardBlock keyboard) 
        {
            this.keyboard = keyboard;
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
        public string name = "";
        public List<MacroBlock> blocks = new List<MacroBlock>();
        
        public Record()
        {

        }
        public Record(Record target)
        {
            this.runIndex = target.runIndex;
            this.name = target.name;
            foreach (MacroBlock block in target.blocks)
                this.blocks.Add(block);
        }
        public void add(MouseBlock mouse)
        {
            blocks.Add(new MacroBlock(mouse));
        }
        public void add(KeyboardBlock keyboard)
        {
            blocks.Add(new MacroBlock(keyboard));
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
        public void insert(int  index, MouseBlock mouse) 
        {
            blocks.Insert(index, new MacroBlock(mouse));
        }
        public void insert(int index, KeyboardBlock keyboard)
        {
            blocks.Insert(index, new MacroBlock(keyboard));
        }
        public void insert(int index, WaitBlock wait) 
        {
            blocks.Insert(index, new MacroBlock(wait));
        }
        public void insert(int index, LoopBlock loop)
        {
            blocks.Insert(index, new MacroBlock(loop));
        }
    }
}
