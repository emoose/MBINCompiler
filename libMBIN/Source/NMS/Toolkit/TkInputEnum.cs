using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x4, GUID = 0xF701733D06A2222E)]
    public class TkInputEnum : NMSTemplate
    {
        // TODO: change to enum
        public enum InputButtonEnum
        {
            None = 0x001, Esc = 0x011, Enter = 0x021, Backspace = 0x031, Del = 0x041, Home = 0x051, End = 0x061, PageUp = 0x071, PageDown = 0x081,
            F1 = 0x091, F2 = 0x0A1, F3 = 0x0B1, F4 = 0x0C1, F5 = 0x0D1, F6 = 0x0E1, F7 = 0x0F1, F8 = 0x101, F9 = 0x111, F10 = 0x121, F11 = 0x131, F12 = 0x141,
            Tab = 0x151, LShift = 0x161, RShift = 0x171, LAlt = 0x181, RAlt = 0x191, LCtrl = 0x1A1, RCtrl = 0x1B1, Up = 0x1C1, Down = 0x1D1, Left = 0x1E1, Right = 0x1F1,
            PadA = 0x201, PadB = 0x211, PadC = 0x221, PadD = 0x231, PadStart = 0x241, PadSelect = 0x251, PadLeftShoulder1 = 0x261, PadRightShoulder1 = 0x271,
            PadLeftShoulder2 = 0x281, PadRightShoulder2 = 0x291, PadLeftTrigger = 0x2A1, PadRightTrigger = 0x2B1, PadLeftThumb = 0x2C1, PadRightThumb = 0x2D1,
            PadUp = 0x2E1, PadDown = 0x2F1, PadLeft = 0x301, PadRight = 0x311, Mouse1 = 0x321, Mouse2 = 0x331, Mouse3 = 0x341, Mouse4 = 0x351, Mouse5 = 0x361,
            Mouse6 = 0x371, Mouse7 = 0x381, Mouse8 = 0x391, AltA = 0x3A1, AltB = 0x3B1, AltC = 0x3C1, AltD = 0x3D1, AltPrimaryMenu = 0x3E1, AltSecondaryMenu = 0x3F1,
            AltPrimarySpecial = 0x401, AltSecondarySpecial = 0x411, AltPrimaryTrigger = 0x421, AltSecondaryTrigger = 0x431, AltPrimaryThumb = 0x441,
            AltSecondaryThumb = 0x451, AltDown = 0x461, AltRight = 0x471, AltLeft = 0x481, AltUp = 0x491, AltPrimaryWW = 0x4A1, AltSecondaryWW = 0x4B1,
            AltPrimaryII = 0x4C1, AltSecondaryII = 0x4D1
        }
        public InputButtonEnum InputButton;
    }
}
