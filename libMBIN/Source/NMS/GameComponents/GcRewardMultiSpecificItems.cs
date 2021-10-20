using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0xF86ED48EA11560E, NameHash = 0x26C3924987148B0B)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        /* 0x0 */ public bool Silent;
        /* 0x8 */ public List<GcMultiSpecificItemEntry> Items;
    }
}
