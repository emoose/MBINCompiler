using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x243BF91D4FF4DE3B, NameHash = 0x8984A8784D46EE5F)]
    public class GcMissionConditionSquadronPilotsOwned : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
