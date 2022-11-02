using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B235D7C7F627E5E, NameHash = 0xA57C34B1B939D649)]
    public class GcCostItemListIndexed : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Costs;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public bool AssertIfOutOfBounds;
        // size: 0x3
        public enum ItemOutOfBoundsBehaviourEnum {
            NoCost,
            UseFirst,
            UseLast
        }
        /* 0x18 */ public ItemOutOfBoundsBehaviourEnum ItemOutOfBoundsBehaviour;
        // size: 0x3
        public enum ItemIndexProviderEnum {
            None,
            Biome,
            SubBiome
        }
        /* 0x1C */ public ItemIndexProviderEnum ItemIndexProvider;
    }
}
