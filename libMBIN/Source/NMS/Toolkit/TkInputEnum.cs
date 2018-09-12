using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x4, GUID = 0x62EB9D0F5E67D4F6)]
    public class TkInputEnum : NMSTemplate
    {
        public int InputButton;
        public Dictionary<int, string> InputButtonDict()
        {
            return new Dictionary<int, string>
            {
                {0x1, "None"},
                {0x11, "Esc"},
                {0x21, "Enter"},
                {0x31, "Backspace"},
                {0x41, "Del"},
                {0x51, "Home"},
                {0x61, "End"},
                {0x71, "PageUp"},
                {0x81, "PageDown"},
                {0x91, "F1"},
                {0xA1, "F2"},
                {0xB1, "F3"},
                {0xC1, "F4"},
                {0xD1, "F5"},
                {0xE1, "F6"},
                {0xF1, "F7"},
                {0x101, "F8"},
                {0x111, "F9"},
                {0x121, "F10"},
                {0x131, "F11"},
                {0x141, "F12"},
                {0x151, "Tab"},
                {0x161, "LShift"},
                {0x171, "RShift"},
                {0x181, "LAlt"},
                {0x191, "RAlt"},
                {0x1A1, "LCtrl"},
                {0x1B1, "RCtrl"},
                {0x1C1, "Up"},
                {0x1D1, "Down"},
                {0x1E1, "Left"},
                {0x1F1, "Right"},
                {0x201, "PadA"},
                {0x211, "PadB"},
                {0x221, "PadC"},
                {0x231, "PadD"},
                {0x241, "PadStart"},
                {0x251, "PadSelect"},
                {0x261, "PadLeftShoulder1"},
                {0x271, "PadRightShoulder1"},
                {0x281, "PadLeftShoulder2"},
                {0x291, "PadRightShoulder2"},
                {0x2A1, "PadLeftTrigger"},
                {0x2B1, "PadRightTrigger"},
                {0x2C1, "PadLeftThumb"},
                {0x2D1, "PadRightThumb"},
                {0x2E1, "PadUp"},
                {0x2F1, "PadDown"},
                {0x301, "PadLeft"},
                {0x311, "PadRight"},
                {0x321, "Mouse1"},
                {0x331, "Mouse2"},
                {0x341, "Mouse3"},
                {0x351, "Mouse4"},
                {0x361, "Mouse5"},
                {0x371, "Mouse6"},
                {0x381, "Mouse7"},
                {0x391, "Mouse8"}
            };
        }
    }
}
