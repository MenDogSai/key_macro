using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace key_macro
{
    struct MouseBlock
    {
        int keyIndex;
        int x;
        int y;
        uint flag;
        void act()
        {

        }
    }
    struct KeyBoardBlock
    {
        int keyIndex;
        uint flag;

        void act()
        {

        }
    }
    struct DelayBlock
    {
        uint time;
        uint flag;

        void act()
        {

        }
    }
    struct LoopBlock
    {
        uint start;
        uint end;
        uint flag;
        void act()
        {

        }
    }
    enum BlockName
    {
        NONE_BLOCK = 0,
        MOUSE_BLOCK = 1,
        KEYBOARD_BLOCK = 2,
        DELAY_BLOCK = 3,
        LOOP_BLOCK = 4,
    }
    struct MacroBlock
    {
        BlockName name;
        MouseBlock mouse;
        KeyBoardBlock keyBoard;
        DelayBlock delay;
        LoopBlock loop;
    }
    public class Record
    {
        int index = 0;
        List<MacroBlock> blocks = new List<MacroBlock>();
        Record() 
        {
            
        }
    }
}
