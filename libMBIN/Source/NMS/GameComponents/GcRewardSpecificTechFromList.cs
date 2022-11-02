using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7ACD354AF15BAD3, NameHash = 0xF33640B1865E5E4B)]
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TechList;
        /* 0x10 */ public bool FailIfAllKnown;
        // size: 0x3
        public enum TechListRewardOrderEnum {
            OneRandom,
            InOrder,
            TryAllRandom
        }
        /* 0x14 */ public TechListRewardOrderEnum TechListRewardOrder;
    }
}
