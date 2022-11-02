using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C6389A7B4A51884, NameHash = 0x26C3924987148B0B)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        /* 0x0 */ public bool Silent;
        /* 0x8 */ public List<GcMultiSpecificItemEntry> Items;
    }
}
