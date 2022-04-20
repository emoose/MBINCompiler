using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x852BC211DC353C65, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes StatType;
        /* 0x4 */ public bool LessIsBetter;
    }
}
