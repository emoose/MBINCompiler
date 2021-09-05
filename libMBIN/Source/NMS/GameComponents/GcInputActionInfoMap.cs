using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2D7C0, GUID = 0x492FFF6340004DD9, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x11C, EnumType = typeof(GcInputActions.InputActionEnum))]
        public GcInputActionInfo[] ActionMap;
    }
}
