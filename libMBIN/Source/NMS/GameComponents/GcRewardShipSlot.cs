using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x6AEED3D0FDE8CBC1, NameHash = 0x5EB3ADA9F4E70000)]
    public class GcRewardShipSlot : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Cost;
        /* 0x10 */ public bool AwardCostAndOpenWindow;
        /* 0x14 */ public int NumTokens;
    }
}
