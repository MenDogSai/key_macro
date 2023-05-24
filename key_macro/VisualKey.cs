using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_macro
{
    static public class VisualKey
    {
        const int KEY_MAX = 256;
        static private string[] name = new string[KEY_MAX];
        static private string[] description = new string[KEY_MAX];
        static public void initialize() 
        {
            for(int i = 0; i < KEY_MAX; i++)
            {
                name[i] = "";
                description[i] = "";
            }
            name[0x01] = "MLB"; description[0x01] = "Mouse Left Button";
            name[0x02] = "MRB"; description[0x02] = "Mouse Right Button";
            name[0x03] = "CBP"; description[0x03] = "Control Break Processing";
            name[0x04] = "MMB"; description[0x04] = "Mouse X1 Button";
            name[0x06] = "MX2"; description[0x06] = "Mouse X2 Button";
            name[0x08] = "BAK"; description[0x08] = "BackSpace Key";
            name[0x09] = "TAB"; description[0x09] = "Tab Key";
            name[0x0A] = "MSU"; description[0x0A] = "Mouse Scroll Up";
            name[0x0B] = "MSD"; description[0x0B] = "Mouse Scroll Down";
            name[0x0C] = "CLR"; description[0x0C] = "Clear Key";
            name[0x0D] = "ENT"; description[0x0D] = "Enter Key";
            name[0x10] = "SHF"; description[0x10] = "Shift Key";
            name[0x11] = "CTL"; description[0x11] = "Ctrl Key";
            name[0x12] = "ALT"; description[0x12] = "Alt Key";
            name[0x13] = "PAU"; description[0x13] = "Pause Key";
            name[0x14] = "CAP"; description[0x14] = "Caps Lock Key";
            name[0x15] = "IHM"; description[0x15] = "IME Hangul Mode";
            name[0x17] = "IJM"; description[0x17] = "IME Junja Mode";
            name[0x18] = "IFM"; description[0x18] = "IME Final Mode";
            name[0x19] = "IHM"; description[0x19] = "IME Hanja Mode";
            name[0x1B] = "ESC"; description[0x1B] = "ESC Key";
            name[0x1C] = "ICO"; description[0x1C] = "IME convert";
            name[0x1D] = "INO"; description[0x1D] = "IME nonconvert";
            name[0x1E] = "IAC"; description[0x1E] = "IME accept";
            name[0x1F] = "IMC"; description[0x1F] = "IME Mode Change Request";
            name[0x20] = "SPA"; description[0x20] = "SpaceBar"; 
            name[0x21] = "PGU"; description[0x21] = "Page Up Key";
            name[0x22] = "PGD"; description[0x22] = "Page Down Key";
            name[0x23] = "END"; description[0x23] = "End Key";
            name[0x24] = "HOM"; description[0x24] = "Home Key";
            name[0x25] = "LAR"; description[0x25] = "Left Arrow Key";
            name[0x26] = "UAR"; description[0x26] = "Up Arrow Key";
            name[0x27] = "RAR"; description[0x27] = "Right Arrow Key";
            name[0x28] = "DAR"; description[0x28] = "Down Arrow Key";
            name[0x29] = "SEL"; description[0x29] = "Select Key";
            name[0x2A] = "PRT"; description[0x2A] = "Print Key";
            name[0x2B] = "EXE"; description[0x2B] = "Execute Key";
            name[0x2C] = "INS"; description[0x2C] = "Insert Key";
            name[0x2E] = "DEL"; description[0x2E] = "Delete Key";
            name[0x2F] = "HLP"; description[0x2F] = "Help Key";
            name[0x30] = "0";   description[0x30] = "0 Key";
            name[0x31] = "1";   description[0x31] = "1 Key";
            name[0x32] = "2";   description[0x32] = "2 Key";
            name[0x33] = "3";   description[0x33] = "3 Key";
            name[0x34] = "4";   description[0x34] = "4 Key";
            name[0x35] = "5";   description[0x35] = "5 Key";
            name[0x36] = "6";   description[0x36] = "6 Key";
            name[0x37] = "7";   description[0x37] = "7 Key";
            name[0x38] = "8";   description[0x38] = "8 Key";
            name[0x39] = "9";   description[0x39] = "9 Key";
            name[0x41] = "A";   description[0x41] = "A Key";
            name[0x42] = "B";   description[0x42] = "B Key";
            name[0x43] = "C";   description[0x43] = "C Key";
            name[0x44] = "D";   description[0x44] = "D Key";
            name[0x45] = "E";   description[0x45] = "E Key";
            name[0x46] = "F";   description[0x46] = "F Key";
            name[0x47] = "G";   description[0x47] = "G Key";
            name[0x48] = "H";   description[0x48] = "H Key";
            name[0x49] = "I";   description[0x49] = "I Key";
            name[0x4A] = "J";   description[0x4A] = "J Key";
            name[0x4B] = "K";   description[0x4B] = "K Key";
            name[0x4C] = "L";   description[0x4C] = "L Key";
            name[0x4D] = "M";   description[0x4D] = "M Key";
            name[0x4E] = "N";   description[0x4E] = "N Key";
            name[0x4F] = "O";   description[0x4F] = "O Key";
            name[0x50] = "P";   description[0x50] = "P Key";
            name[0x51] = "Q";   description[0x51] = "Q Key";
            name[0x52] = "R";   description[0x52] = "R Key";
            name[0x53] = "S";   description[0x53] = "S Key";
            name[0x54] = "T";   description[0x54] = "T Key";
            name[0x55] = "U";   description[0x55] = "U Key";
            name[0x56] = "V";   description[0x56] = "V Key";
            name[0x57] = "W";   description[0x57] = "W Key";
            name[0x58] = "X";   description[0x58] = "X Key";
            name[0x59] = "Y";   description[0x59] = "Y Key";
            name[0x5A] = "Z";   description[0x5A] = "Z Key";
            name[0x5B] = "LWK"; description[0x5B] = "Left Windows Key";
            name[0x5C] = "RWK"; description[0x5C] = "Right Windows Key";
            name[0x5D] = "APP"; description[0x5D] = "Applications Key";
            name[0x5F] = "CSK"; description[0x5F] = "Computer Sleep Key";
            name[0x60] = "NK0"; description[0x60] = "Numeric Keypad 0 Key";
            name[0x61] = "NK1"; description[0x61] = "Numeric Keypad 1 Key";
            name[0x62] = "NK2"; description[0x62] = "Numeric Keypad 2 Key";
            name[0x63] = "NK3"; description[0x63] = "Numeric Keypad 3 Key";
            name[0x64] = "NK4"; description[0x64] = "Numeric Keypad 4 Key";
            name[0x65] = "NK5"; description[0x65] = "Numeric Keypad 5 Key";
            name[0x66] = "NK6"; description[0x66] = "Numeric Keypad 6 Key";
            name[0x67] = "NK7"; description[0x67] = "Numeric Keypad 7 Key";
            name[0x68] = "NK8"; description[0x68] = "Numeric Keypad 8 Key";
            name[0x69] = "NK9"; description[0x69] = "Numeric Keypad 9 Key";
            name[0x6A] = "MUL"; description[0x6A] = "Multiply Key";
            name[0x6B] = "ADD"; description[0x6B] = "Add Key";
            name[0x6C] = "SEP"; description[0x6C] = "Separator Key";
            name[0x6E] = "SUB"; description[0x6E] = "Subtract Key";
            name[0x6F] = "DIV"; description[0x6F] = "Divide Key";
            name[0x70] = "F1";  description[0x70] = "F1 Key";
            name[0x71] = "F2";  description[0x71] = "F2 Key";
            name[0x72] = "F3";  description[0x72] = "F3 Key";
            name[0x73] = "F4";  description[0x73] = "F4 Key";
            name[0x74] = "F5";  description[0x74] = "F5 Key";
            name[0x75] = "F6";  description[0x75] = "F6 Key";
            name[0x76] = "F7";  description[0x76] = "F7 Key";
            name[0x77] = "F8";  description[0x77] = "F8 Key";
            name[0x78] = "F9";  description[0x78] = "F9 Key";
            name[0x79] = "F10"; description[0x79] = "F10 Key";
            name[0x7A] = "F11"; description[0x7A] = "F11 Key";
            name[0x7B] = "F12"; description[0x7B] = "F12 Key";
            name[0x90] = "NUM"; description[0x90] = "Num Lock Key";
            name[0x91] = "SLR"; description[0x91] = "Scroll Lock Key";
            name[0xA0] = "LSH"; description[0xA0] = "Left Shift Key";
            name[0xA1] = "RSK"; description[0xA1] = "Right Shift Key";
            name[0xA2] = "LCL"; description[0xA2] = "Left Control Key";
            name[0xA3] = "RCL"; description[0xA3] = "Right Control Key";
            name[0xA4] = "LMK"; description[0xA4] = "Left Menu Key";
            name[0xA5] = "RMK"; description[0xA5] = "Right Menu Key";
            name[0xA6] = "BBK"; description[0xA6] = "Browser Back Key";
            name[0xA7] = "BFK"; description[0xA7] = "Browser Forward Key";
            name[0xA8] = "BRK"; description[0xA8] = "Browser Refresh Key";
            name[0xA9] = "BSK"; description[0xA9] = "Browser Stop Key";
            name[0xAA] = "BSE"; description[0xAA] = "Browser Search Key";
            name[0xAB] = "BFK"; description[0xAB] = "Browser Favorites Key";
            name[0xAC] = "BSH"; description[0xAC] = "Browser Start and Home Key";
            name[0xAD] = "VMK"; description[0xAD] = "Volume Mute Key";
            name[0xAE] = "VDK"; description[0xAE] = "Volume Down Key";
            name[0xAF] = "VUK"; description[0xAF] = "Volume Up Key";
            name[0xB0] = "NTK"; description[0xB0] = "Next Track Key";
            name[0xB1] = "PTK"; description[0xB1] = "Previous Track Key";
            name[0xB2] = "SMK"; description[0xB2] = "Stop Media Key";
            name[0xB3] = "PPM"; description[0xB3] = "Play/Pause Media Key";
            name[0xB4] = "SMA"; description[0xB4] = "Start Mail Key";
            name[0xB5] = "SMK"; description[0xB5] = "Select Media Key";
            name[0xB6] = "SA1"; description[0xB6] = "Start Application 1 Key";
            name[0xB7] = "SA2"; description[0xB7] = "Start Application 2 Key";
            name[0xBA] = ";:";  description[0xBA] = ";: Key";
            name[0xBB] = "=+";  description[0xBB] = "=+ Key";
            name[0xBC] = ",<";  description[0xBC] = ",< Key";
            name[0xBD] = "-_";  description[0xBD] = "-_ Key";
            name[0xBE] = ".>";  description[0xBE] = ".> Key";
            name[0xBF] = "/?";  description[0xBF] = "/? Key";
            name[0xC0] = "`~";  description[0xC0] = "`~ Key";
            name[0xDB] = "[{";  description[0xDB] = "[{ Key";
            name[0xDC] = "\\|"; description[0xDC] = "\\| Key";
            name[0xDD] = "]}";  description[0xDD] = "]} Key";
            name[0xDE] = "'\""; description[0xDE] = "'\" Key";
        }
        static public string getKeyDescription(int key)
        {
            key = key & 0xFF;
            return description[key];
        }
        static public int getKeyIndex(string keyName) 
        { 
            for(int i = 0; i < KEY_MAX;  i++)
                if (name[i] == keyName) 
                    return i;
            return -1;
        }
    }
}
