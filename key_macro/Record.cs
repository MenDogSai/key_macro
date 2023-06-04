using Key_macro;
using System;
using System.CodeDom;
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
    public class MouseBlock
    {
        public string description;
        private INPUT input;
        public MouseBlock(Point point)
        {
            Point temp = Win32.ScreenToMousePosition(point);
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
                temp = Win32.ScreenToMousePosition(point);
                description = $"마우스 [{point.X},{point.Y}] ";
            }
            input.type = Win32.INPUT_MOUSE;
            input.mi.dwExtraInfo = IntPtr.Zero;
            input.mi.dx = temp.X;
            input.mi.dy = temp.Y;
            input.mi.dwFlags   = MOUSEEVENTF.MOUSEEVENTF_MOVE | MOUSEEVENTF.MOUSEEVENTF_VIRTUALDESK | MOUSEEVENTF.MOUSEEVENTF_ABSOLUTE;
            input.mi.dwFlags  |= GetMouseFlag(mouse.buttonFlags);
            input.mi.mouseData = GetMouseData(mouse.buttonFlags, mouse.buttonData);
        }
        public bool Act()
        {
            if(input.mi.dx == -1 && input.mi.dy == -1) {
                Point temp = Win32.ScreenToMousePosition(Cursor.Position);
                input.mi.dx = temp.X;
                input.mi.dy = temp.Y;
            }
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
            return true;
        }
        private MOUSEEVENTF GetMouseFlag(RawMouseButtons buttons)
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
        private int GetMouseData(RawMouseButtons buttons, ushort buttonData)
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
        public string description;
        private INPUT input;

        public KeyboardBlock(RawKeyboard keyboard)
        {
            const uint PRESSED = 1;
            input.ki.wVk = keyboard.vkey;
            input.ki.wScan = keyboard.makeCode;
            input.ki.dwFlags = (keyboard.message & PRESSED) * 2;
            input.ki.dwExtraInfo = IntPtr.Zero;
            description = $"키보드 [{VisualKey.GetKeyDescription(keyboard.vkey)}] → ";
            description += ((keyboard.message & PRESSED) == 0) ? "누름" : "뗌";
        }
        public bool Act()
        {
            INPUT[] inputs = { input };
            Win32.SendInput(1, inputs, Marshal.SizeOf(typeof(INPUT)));
            return true;
        }
    }
    public class WaitBlock
    {
        public string description;
        private readonly long endTime;
        private DateTime beforeTime;
        public WaitBlock(long time)
        {
            this.endTime = time;
            description = $"시간지연 {time/1000}.{time%1000} 초";
        }
        public bool Act()
        {
            DateTime nowTime = DateTime.Now;
            long currentTime = (nowTime.Ticks - beforeTime.Ticks) / 10000;
            beforeTime = nowTime;
            return currentTime < endTime;
        }
    }
    /// <summary>
    /// Count 값이 -1 값이면 무한 반복
    /// </summary>
    public class LoopBlock
    {
        public string description;
        private readonly int start = 0;
        private int count = 0;

        public LoopBlock(int start, int count)
        {
            this.description = $"반복 횟수:{count}";
            this.start = start;
            this.count = count;

            //카운트 값이 0 이면 -1로 변환 해서 무한 반복으로 변경
            if (count == 0)
            {
               this.description = "무한 반복";
               this.count = -1;
            }
        }
        public int Act(int index)
        {
            if (count == 0)
                return index + 1;

            count = (count < 0)? -1: count - 1;
            return start;
        }
    }
    public enum BlockName
    {
        MouseBlock = 0,
        KeyboardBlock,
        WaitBlock,
        LoopBlock,
    }
    public class MacroBlock
    {
        public BlockName name;
        public MouseBlock mouse = null;
        public KeyboardBlock keyboard = null;
        public WaitBlock wait = null;
        public LoopBlock loop = null;
        public MacroBlock(MouseBlock mouse)
        {
            this.name = BlockName.MouseBlock;
            this.mouse = mouse;
        }
        public MacroBlock (KeyboardBlock keyboard) 
        {
            this.name = BlockName.KeyboardBlock;
            this.keyboard = keyboard;
        }
        public MacroBlock(WaitBlock wait) 
        {
            this.name = BlockName.WaitBlock;
            this.wait = wait;
        }
        public MacroBlock(LoopBlock loop) 
        {
            this.name = BlockName.LoopBlock;
            this.loop = loop;
        }
    }
    public class Record
    {
        public string name = "";
        public List<MacroBlock> blocks = new List<MacroBlock>();

        private bool stopFlag = false;
        public Record()
        {

        }
        public Record(Record target)
        {
            this.name = target.name;
            foreach (MacroBlock block in target.blocks)
            {
                this.blocks.Add(block);
            }
        }
        public void Add(MouseBlock mouse)
        {
            blocks.Add(new MacroBlock(mouse));
        }
        public void Add(KeyboardBlock keyboard)
        {
            blocks.Add(new MacroBlock(keyboard));
        }
        public void Add(WaitBlock wait)
        {
            blocks.Add(new MacroBlock(wait));
        }
        public void Add(LoopBlock loop)
        {
            blocks.Add(new MacroBlock(loop));
        }
        public void Clear()
        {
            blocks.Clear();
        }
        public void Insert(int  index, MouseBlock mouse) 
        {
            blocks.Insert(index, new MacroBlock(mouse));
        }
        public void Insert(int index, KeyboardBlock keyboard)
        {
            blocks.Insert(index, new MacroBlock(keyboard));
        }
        public void Insert(int index, WaitBlock wait) 
        {
            blocks.Insert(index, new MacroBlock(wait));
        }
        public void Insert(int index, LoopBlock loop)
        {
            blocks.Insert(index, new MacroBlock(loop));
        }
        public void Run()
        {
            stopFlag = false;
            Task task = new Task(() => this.Execute());
            task.Start();
        }
        public void Stop()
        {
            stopFlag = true;
        }
        private void Execute()
        {
            if (blocks.Count == 0) return;
            int i = 0;
            while (i < blocks.Count)
            {
                switch (blocks[i].name)
                {
                    case BlockName.MouseBlock:
                        if(blocks[i].mouse.Act())
                            i++; 
                        break;
                    case BlockName.KeyboardBlock:
                        if (blocks[i].keyboard.Act())
                            i++; 
                        break;
                    case BlockName.WaitBlock:
                        if (blocks[i].wait.Act())
                            i++; 
                        break;
                    case BlockName.LoopBlock:
                            i = blocks[i].loop.Act(i);
                        break;
                }
                if (stopFlag) break;
            }
        }
    }//end of Record class
}
