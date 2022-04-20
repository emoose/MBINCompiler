using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x5C86DE9A205C73E7, NameHash = 0x29E2A09E517103EE)]
    public class GcRewardIncrementStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public int Amount;
    }
}
