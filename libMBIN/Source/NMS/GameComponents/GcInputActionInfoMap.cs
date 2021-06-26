using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2BB90, GUID = 0x6243D528366BE6, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x111, EnumType = typeof(GcInputActions.InputActionEnum))]
        public GcInputActionInfo[] ActionMap;
    }
}
