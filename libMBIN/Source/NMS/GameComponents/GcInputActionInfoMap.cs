using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2DCE0, GUID = 0x4238DB08FB1DDD9F, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x11E, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
