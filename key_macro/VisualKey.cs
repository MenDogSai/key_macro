using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            name[0x01] = "MLB"; description[0x01] = "마우스 왼쪽 버튼";
            name[0x02] = "MRB"; description[0x02] = "마우스 오른쪽 버튼";
            name[0x03] = "CBP"; description[0x03] = "Control Break Processing";
            name[0x04] = "MMB"; description[0x04] = "마우스 X1 버튼";
            name[0x06] = "MX2"; description[0x06] = "마우스 X2 버튼";
            name[0x08] = "BAK"; description[0x08] = "BackSpace 키";
            name[0x09] = "TAB"; description[0x09] = "Tab 키";
            name[0x0A] = "MSU"; description[0x0A] = "마우스 스크롤 증가";
            name[0x0B] = "MSD"; description[0x0B] = "마우스 스크롤 감소";
            name[0x0C] = "CLR"; description[0x0C] = "Clear 키";
            name[0x0D] = "ENT"; description[0x0D] = "Enter 키";
            name[0x10] = "SHF"; description[0x10] = "Shift 키";
            name[0x11] = "CTL"; description[0x11] = "Ctrl 키";
            name[0x12] = "ALT"; description[0x12] = "Alt 키";
            name[0x13] = "PAU"; description[0x13] = "Pause 키";
            name[0x14] = "CAP"; description[0x14] = "Caps Lock y";
            name[0x15] = "IHM"; description[0x15] = "IME 한영 키";
            name[0x17] = "IJM"; description[0x17] = "IME Junja Mode";
            name[0x18] = "IFM"; description[0x18] = "IME Final Mode";
            name[0x19] = "IHM"; description[0x19] = "IME Hanja Mode";
            name[0x1B] = "ESC"; description[0x1B] = "ESC 키";
            name[0x1C] = "ICO"; description[0x1C] = "IME convert";
            name[0x1D] = "INO"; description[0x1D] = "IME nonconvert";
            name[0x1E] = "IAC"; description[0x1E] = "IME accept";
            name[0x1F] = "IMC"; description[0x1F] = "IME Mode Change Request";
            name[0x20] = "SPA"; description[0x20] = "SpaceBar"; 
            name[0x21] = "PGU"; description[0x21] = "Page Up 키";
            name[0x22] = "PGD"; description[0x22] = "Page Down 키";
            name[0x23] = "END"; description[0x23] = "End 키";
            name[0x24] = "HOM"; description[0x24] = "Home 키";
            name[0x25] = "LAR"; description[0x25] = "Left 방향 키";
            name[0x26] = "UAR"; description[0x26] = "Up 방향 키";
            name[0x27] = "RAR"; description[0x27] = "Right 방향 키";
            name[0x28] = "DAR"; description[0x28] = "Down 방향 키";
            name[0x29] = "SEL"; description[0x29] = "Select 키";
            name[0x2A] = "PRT"; description[0x2A] = "Print 키";
            name[0x2B] = "EXE"; description[0x2B] = "Execute 키";
            name[0x2C] = "INS"; description[0x2C] = "Insert 키";
            name[0x2E] = "DEL"; description[0x2E] = "Delete 키";
            name[0x2F] = "HLP"; description[0x2F] = "Help 키";
            name[0x30] = "0";   description[0x30] = "0 키";
            name[0x31] = "1";   description[0x31] = "1 키";
            name[0x32] = "2";   description[0x32] = "2 키";
            name[0x33] = "3";   description[0x33] = "3 키";
            name[0x34] = "4";   description[0x34] = "4 키";
            name[0x35] = "5";   description[0x35] = "5 키";
            name[0x36] = "6";   description[0x36] = "6 키";
            name[0x37] = "7";   description[0x37] = "7 키";
            name[0x38] = "8";   description[0x38] = "8 키";
            name[0x39] = "9";   description[0x39] = "9 키";
            name[0x41] = "A";   description[0x41] = "A 키";
            name[0x42] = "B";   description[0x42] = "B 키";
            name[0x43] = "C";   description[0x43] = "C 키";
            name[0x44] = "D";   description[0x44] = "D 키";
            name[0x45] = "E";   description[0x45] = "E 키";
            name[0x46] = "F";   description[0x46] = "F 키";
            name[0x47] = "G";   description[0x47] = "G 키";
            name[0x48] = "H";   description[0x48] = "H 키";
            name[0x49] = "I";   description[0x49] = "I 키";
            name[0x4A] = "J";   description[0x4A] = "J 키";
            name[0x4B] = "K";   description[0x4B] = "K 키";
            name[0x4C] = "L";   description[0x4C] = "L 키";
            name[0x4D] = "M";   description[0x4D] = "M 키";
            name[0x4E] = "N";   description[0x4E] = "N 키";
            name[0x4F] = "O";   description[0x4F] = "O 키";
            name[0x50] = "P";   description[0x50] = "P 키";
            name[0x51] = "Q";   description[0x51] = "Q 키";
            name[0x52] = "R";   description[0x52] = "R 키";
            name[0x53] = "S";   description[0x53] = "S 키";
            name[0x54] = "T";   description[0x54] = "T 키";
            name[0x55] = "U";   description[0x55] = "U 키";
            name[0x56] = "V";   description[0x56] = "V 키";
            name[0x57] = "W";   description[0x57] = "W 키";
            name[0x58] = "X";   description[0x58] = "X 키";
            name[0x59] = "Y";   description[0x59] = "Y 키";
            name[0x5A] = "Z";   description[0x5A] = "Z 키";
            name[0x5B] = "LWK"; description[0x5B] = "왼쪽 Windows 키";
            name[0x5C] = "RWK"; description[0x5C] = "오른쪽 Windows Key";
            name[0x5D] = "APP"; description[0x5D] = "Applications Key";
            name[0x5F] = "CSK"; description[0x5F] = "Computer Sleep Key";
            name[0x60] = "NK0"; description[0x60] = "키 패드 0 키";
            name[0x61] = "NK1"; description[0x61] = "키 패드 1 키";
            name[0x62] = "NK2"; description[0x62] = "키 패드 2 키";
            name[0x63] = "NK3"; description[0x63] = "키 패드 3 키";
            name[0x64] = "NK4"; description[0x64] = "키 패드 4 키";
            name[0x65] = "NK5"; description[0x65] = "키 패드 5 키";
            name[0x66] = "NK6"; description[0x66] = "키 패드 6 키";
            name[0x67] = "NK7"; description[0x67] = "키 패드 7 키";
            name[0x68] = "NK8"; description[0x68] = "키 패드 8 키";
            name[0x69] = "NK9"; description[0x69] = "키 패드 9 키";
            name[0x6A] = "MUL"; description[0x6A] = "키 패드 * 키";
            name[0x6B] = "ADD"; description[0x6B] = "키 패드 + 키";
            name[0x6C] = "SEP"; description[0x6C] = "Separator 키";
            name[0x6D] = "SUB"; description[0x6D] = "키 패드 - 키";
            name[0x6E] = "DEC"; description[0x6E] = "키 패드 Del 키";
            name[0x6F] = "DIV"; description[0x6F] = "키 패드 / 키";
            name[0x70] = "F1";  description[0x70] = "F1 키";
            name[0x71] = "F2";  description[0x71] = "F2 키";
            name[0x72] = "F3";  description[0x72] = "F3 키";
            name[0x73] = "F4";  description[0x73] = "F4 키";
            name[0x74] = "F5";  description[0x74] = "F5 키";
            name[0x75] = "F6";  description[0x75] = "F6 키";
            name[0x76] = "F7";  description[0x76] = "F7 키";
            name[0x77] = "F8";  description[0x77] = "F8 키";
            name[0x78] = "F9";  description[0x78] = "F9 키";
            name[0x79] = "F10"; description[0x79] = "F10 키";
            name[0x7A] = "F11"; description[0x7A] = "F11 키";
            name[0x7B] = "F12"; description[0x7B] = "F12 키";
            name[0x90] = "NUM"; description[0x90] = "Num Lock 키";
            name[0x91] = "SLR"; description[0x91] = "Scroll Lock 키";
            name[0xA0] = "LSH"; description[0xA0] = "왼쪽 Shift 키";
            name[0xA1] = "RSK"; description[0xA1] = "오른쪽 Shift 키";
            name[0xA2] = "LCL"; description[0xA2] = "왼쪽 Control 키";
            name[0xA3] = "RCL"; description[0xA3] = "오른쪽 Control 키";
            name[0xA4] = "LMK"; description[0xA4] = "왼쪽 Menu 키";
            name[0xA5] = "RMK"; description[0xA5] = "오른쪽 Menu 키";
            name[0xA6] = "BBK"; description[0xA6] = "Browser Back 키";
            name[0xA7] = "BFK"; description[0xA7] = "Browser Forward 키";
            name[0xA8] = "BRK"; description[0xA8] = "Browser Refresh 키";
            name[0xA9] = "BSK"; description[0xA9] = "Browser Stop 키";
            name[0xAA] = "BSE"; description[0xAA] = "Browser Search 키";
            name[0xAB] = "BFK"; description[0xAB] = "Browser Favorites 키";
            name[0xAC] = "BSH"; description[0xAC] = "Browser Start and Home 키";
            name[0xAD] = "VMK"; description[0xAD] = "음향 Mute 키";
            name[0xAE] = "VDK"; description[0xAE] = "음향 Down 키";
            name[0xAF] = "VUK"; description[0xAF] = "음향 Up 키";
            name[0xB0] = "NTK"; description[0xB0] = "다음 Track 키";
            name[0xB1] = "PTK"; description[0xB1] = "이전 Track 키";
            name[0xB2] = "SMK"; description[0xB2] = "정지 Media 키";
            name[0xB3] = "PPM"; description[0xB3] = "시작/정지 Media 키";
            name[0xB4] = "SMA"; description[0xB4] = "시작 Mail 키";
            name[0xB5] = "SMK"; description[0xB5] = "Select Media 키";
            name[0xB6] = "SA1"; description[0xB6] = "Start Application 1 키";
            name[0xB7] = "SA2"; description[0xB7] = "Start Application 2 키";
            name[0xBA] = ";:";  description[0xBA] = ";: 키";
            name[0xBB] = "=+";  description[0xBB] = "=+ 키";
            name[0xBC] = ",<";  description[0xBC] = ",< 키";
            name[0xBD] = "-_";  description[0xBD] = "-_ 키";
            name[0xBE] = ".>";  description[0xBE] = ".> 키";
            name[0xBF] = "/?";  description[0xBF] = "/? 키";
            name[0xC0] = "`~";  description[0xC0] = "`~ 키";
            name[0xDB] = "[{";  description[0xDB] = "[{ 키";
            name[0xDC] = "\\|"; description[0xDC] = "\\| 키";
            name[0xDD] = "]}";  description[0xDD] = "]} 키";
            name[0xDE] = "'\""; description[0xDE] = "'\" 키";
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
