using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x4, GUID = 0x3BDC2B8E92F94977, SubGUID = 0x6DC70ADC2461C621)]
    public class TkInputAxisEnum : NMSTemplate
    {
        // 0x1F entries
        public enum InputAxisEnum { None, Invalid, LeftStick, LeftStickX, LeftStickY, RightStick, RightStickX, RightStickY, LeftTrigger, RightTrigger,
            Mouse, MouseX, MouseY, MouseWheel, Touchpad, TouchpadX, TouchpadY, LeftGrip, RightGrip, LeftStickPositiveX, LeftStickNegativeX, LeftStickPositiveY,
            LeftStickNegativeY, RightStickPositiveX, RightStickNegativeX, RightStickPositiveY, RightStickNegativeY, DirectionalPadX, DirectionalPadY,
            DirectionalButtonsX, DirectionalButtonsY }
        public InputAxisEnum InputAxis;
    }
}
