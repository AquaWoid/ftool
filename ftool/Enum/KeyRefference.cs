using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftool.Enum
{
    internal class KeyRefference
    {
        public IntPtr D1 = new IntPtr(0x31);
        public IntPtr D2 = new IntPtr(0x32);
        public IntPtr D3 = new IntPtr(0x33);
        public IntPtr D4 = new IntPtr(0x34);
        public IntPtr D5 = new IntPtr(0x35);
        public IntPtr D6 = new IntPtr(0x36);
        public IntPtr D7 = new IntPtr(0x37);
        public IntPtr D8 = new IntPtr(0x38);
        public IntPtr D9 = new IntPtr(0x39);

        public IntPtr F1 = new IntPtr(0x70);
        public IntPtr F2 = new IntPtr(0x71);
        public IntPtr F3 = new IntPtr(0x72);
        public IntPtr F4 = new IntPtr(0x73);
        public IntPtr F5 = new IntPtr(0x74);
        public IntPtr F6 = new IntPtr(0x75);
        public IntPtr F7 = new IntPtr(0x76);
        public IntPtr F8 = new IntPtr(0x77);
        public IntPtr F9 = new IntPtr(0x78);

        IntPtr keyOut;
        IntPtr fKeyOut;

        public IntPtr getSelectedKey(int keyNumber, bool fMode)
        {

            switch (keyNumber)
            {
                case 1:
                    keyOut = D1;
                    fKeyOut = F1;
                    break;
                case 2:
                    keyOut = D2;
                    fKeyOut = F2;
                    break;
                case 3:
                    keyOut = D3;
                    fKeyOut = F3;
                    break;
                case 4:
                    keyOut = D4;
                    fKeyOut = F4;
                    break;
                case 5:
                    keyOut = D5;
                    fKeyOut = F5;
                    break;
                case 6:
                    keyOut = D6;
                    fKeyOut = F6;
                    break;
                case 7:
                    keyOut = D7;
                    fKeyOut = F7;
                    break;
                case 8:
                    keyOut = D8;
                    fKeyOut = F8;
                    break;
                case 9:
                    keyOut = D9;
                    fKeyOut = F9;
                    break;
            }
            if (fMode)
            {
                return fKeyOut;
            }
            else
            {

                return keyOut;
            }

        }

    }
}
