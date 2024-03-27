using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70D4DBB1996C8F42, NameHash = 0xCD501C8D037C74A5)]
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        // size: 0x4
        public enum ProductListRewardOrderEnum : uint {
            OneRandom,
            InOrder,
            TryAllRandom,
            TryUnknownRandom,
        }
        /* 0x10 */ public ProductListRewardOrderEnum ProductListRewardOrder;
    }
}
