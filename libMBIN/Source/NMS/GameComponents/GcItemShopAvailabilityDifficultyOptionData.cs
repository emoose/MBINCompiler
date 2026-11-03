using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74944F0C1F5FE416, NameHash = 0xDF55E55A)]
    public class GcItemShopAvailabilityDifficultyOptionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> NeverSoldItems;
    }
}
