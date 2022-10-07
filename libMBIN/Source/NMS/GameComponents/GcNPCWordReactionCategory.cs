using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40592D2BE6E8BA34, NameHash = 0x68CB2B62199F1EFA)]
    public class GcNPCWordReactionCategory : NMSTemplate
    {
        // size: 0x7
        public enum CategoriesEnum {
            MISC,
            DIRECTIONS,
            HELP,
            TRADE,
            LORE,
            TECH,
            THREAT
        }
        [NMS(Size = 0x7, EnumType = typeof(CategoriesEnum))]
        /* 0x00 */ public GcNPCWordReactionList[] Categories;
        /* 0x70 */ public GcNPCWordReactionList Fallback;
    }
}
