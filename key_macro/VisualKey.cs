using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_macro
{
    public struct VisualKey
    {
        public string name;
        public string description;
        public VisualKey(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }

    static public class VisualKeys
    {
        static private VisualKey[] visualKey = new VisualKey[255];
        static public void initialize() 
        {
            for(int i = 0; i < visualKey.Length; i++)
            {
                visualKey[i].name = "";
                visualKey[i].description = "";
            }
            visualKey[0x01] = new VisualKey("MLB", "Mouse Left Button" );
            visualKey[0x02] = new VisualKey("MRB", "Mouse Right Button");
            visualKey[0x03] = new VisualKey("CBP", "Control Break Processing");
            visualKey[0x04] = new VisualKey("MMB", "Mouse X1 Button");
            visualKey[0x06] = new VisualKey("MX2", "Mouse X2 Button");
            visualKey[0x08] = new VisualKey("BAK", "BackSpace Key");
            visualKey[0x09] = new VisualKey("TAB", "TAB Key");
            visualKey[0x0A] = new VisualKey("MSU", "Mouse Scroll Up");
            visualKey[0x0B] = new VisualKey("MSD", "Mouse Scroll Down");
            visualKey[0x0C] = new VisualKey("CLR", "CLEAR Key");
            visualKey[0x0D] = new VisualKey("ENT", "ENTER Key");
            visualKey[0x10] = new VisualKey("SHF", "SHIFT Key");
            visualKey[0x11] = new VisualKey("CTL", "CTRL Key");
            visualKey[0x12] = new VisualKey("ALT", "ALT Key");
            visualKey[0x13] = new VisualKey("PAU", "PAUSE Key");
            visualKey[0x14] = new VisualKey("CAP", "CAPS LOCK Key");
            visualKey[0x15] = new VisualKey("IHM", "IME Hangul Mode");
            visualKey[0x17] = new VisualKey("IJM", "IME Junja Mode");
            visualKey[0x18] = new VisualKey("IFM", "IME Final Mode");
            visualKey[0x19] = new VisualKey("IHM", "IME Hanja Mode");
            visualKey[0x1B] = new VisualKey("ESC", "ESC Key");
            visualKey[0x1C] = new VisualKey("ICO", "IME convert");
            visualKey[0x1D] = new VisualKey("INO", "IME nonconvert");
            visualKey[0x1E] = new VisualKey("IAC", "IME accept");
            visualKey[0x1F] = new VisualKey("IMC", "IME Mode Change Request");
            visualKey[0x20] = new VisualKey("SPA", "SPACEBAR");
            visualKey[0x21] = new VisualKey("PGU", "PAGE Up Key");
            visualKey[0x22] = new VisualKey("PGD", "PAGE Down Key");
            visualKey[0x23] = new VisualKey("END", "END Key");
            visualKey[0x24] = new VisualKey("HOM", "HOME Key");
            visualKey[0x25] = new VisualKey("LAR", "LEFT ARROW Key");
            visualKey[0x26] = new VisualKey("UAR", "UP ARROW Key");
            visualKey[0x27] = new VisualKey("RAR", "RIGHT ARROW Key");
            visualKey[0x28] = new VisualKey("DAR", "DOWN ARROW Key");
            visualKey[0x29] = new VisualKey("SEL", "SELECT Key");
            visualKey[0x2A] = new VisualKey("PRT", "PRINT Key");
            visualKey[0x2B] = new VisualKey("EXE", "EXECUTE Key");
            visualKey[0x2C] = new VisualKey("INS", "INS Key");
            visualKey[0x2E] = new VisualKey("DEL", "DEL Key");
            visualKey[0x2F] = new VisualKey("HLP", "HELP Key");
            visualKey[0x30] = new VisualKey("0", "0 Key");
            visualKey[0x31] = new VisualKey("1", "1 Key");
            visualKey[0x32] = new VisualKey("2", "2 Key");
            visualKey[0x33] = new VisualKey("3", "3 Key");
            visualKey[0x34] = new VisualKey("4", "4 Key");
            visualKey[0x35] = new VisualKey("5", "5 Key");
            visualKey[0x36] = new VisualKey("6", "6 Key");
            visualKey[0x37] = new VisualKey("7", "7 Key");
            visualKey[0x38] = new VisualKey("8", "8 Key");
            visualKey[0x39] = new VisualKey("9", "9 Key");
            visualKey[0x41] = new VisualKey("A", "A Key");
            visualKey[0x42] = new VisualKey("B", "B Key");
            visualKey[0x43] = new VisualKey("C", "C Key");
            visualKey[0x44] = new VisualKey("D", "D Key");
            visualKey[0x45] = new VisualKey("E", "E Key");
            visualKey[0x46] = new VisualKey("F", "F Key");
            visualKey[0x47] = new VisualKey("G", "G Key");
            visualKey[0x48] = new VisualKey("H", "H Key");
            visualKey[0x49] = new VisualKey("I", "I Key");
            visualKey[0x4A] = new VisualKey("J", "J Key");
            visualKey[0x4B] = new VisualKey("K", "K Key");
            visualKey[0x4C] = new VisualKey("L", "L Key");
            visualKey[0x4D] = new VisualKey("M", "M Key");
            visualKey[0x4E] = new VisualKey("N", "N Key");
            visualKey[0x4F] = new VisualKey("O", "O Key");
            visualKey[0x50] = new VisualKey("P", "P Key");
            visualKey[0x51] = new VisualKey("Q", "Q Key");
            visualKey[0x52] = new VisualKey("R", "R Key");
            visualKey[0x53] = new VisualKey("S", "S Key");
            visualKey[0x54] = new VisualKey("T", "T Key");
            visualKey[0x55] = new VisualKey("U", "U Key");
            visualKey[0x56] = new VisualKey("V", "V Key");
            visualKey[0x57] = new VisualKey("W", "W Key");
            visualKey[0x58] = new VisualKey("X", "X Key");
            visualKey[0x59] = new VisualKey("Y", "Y Key");
            visualKey[0x5A] = new VisualKey("Z", "Z Key");
            visualKey[0x5B] = new VisualKey("LWK", "Left Windows Key");
            visualKey[0x5C] = new VisualKey("RWK", "Right Windows Key");
            visualKey[0x5D] = new VisualKey("APP", "Applications Key");
            visualKey[0x5F] = new VisualKey("CSK", "Computer Sleep Key");
            visualKey[0x60] = new VisualKey("NK0", "Numeric Keypad 0 Key");
            visualKey[0x61] = new VisualKey("NK1", "Numeric Keypad 1 Key");
            visualKey[0x62] = new VisualKey("NK2", "Numeric Keypad 2 Key");
            visualKey[0x63] = new VisualKey("NK3", "Numeric Keypad 3 Key");
            visualKey[0x64] = new VisualKey("NK4", "Numeric Keypad 4 Key");
            visualKey[0x65] = new VisualKey("NK5", "Numeric Keypad 5 Key");
            visualKey[0x66] = new VisualKey("NK6", "Numeric Keypad 6 Key");
            visualKey[0x67] = new VisualKey("NK7", "Numeric Keypad 7 Key");
            visualKey[0x68] = new VisualKey("NK8", "Numeric Keypad 8 Key");
            visualKey[0x69] = new VisualKey("NK9", "Numeric Keypad 9 Key");
            visualKey[0x6A] = new VisualKey("MUL", "Multiply Key");
            visualKey[0x6B] = new VisualKey("ADD", "Add Key");
            visualKey[0x6C] = new VisualKey("SEP", "Separator Key");
            visualKey[0x6E] = new VisualKey("SUB", "Subtract Key");
            visualKey[0x6F] = new VisualKey("DIV", "Divide Key");
            visualKey[0x70] = new VisualKey("F1", "F1 Key");
            visualKey[0x71] = new VisualKey("F2", "F2 Key");
            visualKey[0x72] = new VisualKey("F3", "F3 Key");
            visualKey[0x73] = new VisualKey("F4", "F4 Key");
            visualKey[0x74] = new VisualKey("F5", "F5 Key");
            visualKey[0x75] = new VisualKey("F6", "F6 Key");
            visualKey[0x76] = new VisualKey("F7", "F7 Key");
            visualKey[0x77] = new VisualKey("F8", "F8 Key");
            visualKey[0x78] = new VisualKey("F9", "F9 Key");
            visualKey[0x79] = new VisualKey("F10", "F10 Key");
            visualKey[0x7A] = new VisualKey("F11", "F11 Key");
            visualKey[0x7B] = new VisualKey("F12", "F12 Key");
            visualKey[0x90] = new VisualKey("NUM", "Num Lock Key");
            visualKey[0x91] = new VisualKey("SLR", "Scroll Lock Key");
            visualKey[0xA0] = new VisualKey("LSH", "Left Shift Key");
            visualKey[0xA1] = new VisualKey("RSK", "Right Shift Key");
            visualKey[0xA2] = new VisualKey("LCL", "Left Control Key");
            visualKey[0xA3] = new VisualKey("RCL", "Right Control Key");
            visualKey[0xA4] = new VisualKey("LMK", "Left Menu Key");
            visualKey[0xA5] = new VisualKey("RMK", "Right Menu Key");
            visualKey[0xA6] = new VisualKey("BBK", "Browser Back Key");
            visualKey[0xA7] = new VisualKey("BFK", "Browser Forward Key");
            visualKey[0xA8] = new VisualKey("BRK", "Browser Refresh Key");
            visualKey[0xA9] = new VisualKey("BSK", "Browser Stop Key");
            visualKey[0xAA] = new VisualKey("BSE", "Browser Search Key");
            visualKey[0xAB] = new VisualKey("BFK", "Browser Favorites Key");
            visualKey[0xAC] = new VisualKey("BSH", "Browser Start and Home Key");
            visualKey[0xAD] = new VisualKey("VMK", "Volume Mute Key");
            visualKey[0xAE] = new VisualKey("VDK", "Volume Down Key");
            visualKey[0xAF] = new VisualKey("VUK", "Volume Up Key");
            visualKey[0xB0] = new VisualKey("NTK", "Next Track Key");
            visualKey[0xB1] = new VisualKey("PTK", "Previous Track Key");
            visualKey[0xB2] = new VisualKey("SMK", "Stop Media Key");
            visualKey[0xB3] = new VisualKey("PPM", "Play/Pause Media Key");
            visualKey[0xB4] = new VisualKey("SMA", "Start Mail Key");
            visualKey[0xB5] = new VisualKey("SMK", "Select Media Key");
            visualKey[0xB6] = new VisualKey("SA1", "Start Application 1 Key");
            visualKey[0xB7] = new VisualKey("SA2", "Start Application 2 Key");
            visualKey[0xBA] = new VisualKey(";:", ";: Key");
            visualKey[0xBB] = new VisualKey("=+", "=+ Key");
            visualKey[0xBC] = new VisualKey(",<", ",< Key");
            visualKey[0xBD] = new VisualKey("-_", "-_ Key");
            visualKey[0xBE] = new VisualKey(".>", ".> Key");
            visualKey[0xBF] = new VisualKey("/?", "/? Key");
            visualKey[0xC0] = new VisualKey("`~", "`~ Key");
            visualKey[0xDB] = new VisualKey("[{", "[{ Key");
            visualKey[0xDC] = new VisualKey("\\|", "\\| Key");
            visualKey[0xDD] = new VisualKey("]}", "]} Key");
            visualKey[0xDE] = new VisualKey("'\"", "'\" Key");
        }
        static public string getKeyDescription(int key)
        {
            key = key & 0xFF;
            return visualKey[key].description;
        }
    }
}
