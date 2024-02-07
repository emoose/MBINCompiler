using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEE8EDDE03DEC00E, NameHash = 0x26C3924987148B0B)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        /* 0x0 */ public bool Silent;
        /* 0x8 */ public List<GcMultiSpecificItemEntry> Items;
    }
}
