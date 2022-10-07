using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD31332AA0EB8E00F, NameHash = 0x8CBF7A7EE4372A7F)]
    public class GcTradingClassTable : NMSTemplate
    {
        // size: 0x7
        public enum TradingClassesDataEnum {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration
        }
        [NMS(Size = 0x7, EnumType = typeof(TradingClassesDataEnum))]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        // size: 0x9
        public enum CategoryDataEnum {
            Mineral,
            Tech,
            Commodity,
            Component,
            Alloy,
            Exotic,
            Energy,
            None,
            SpecialShop
        }
        [NMS(Size = 0x9, EnumType = typeof(CategoryDataEnum))]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xB70 */ public float MaxTradingMultiplier;
        /* 0xB74 */ public float MinTradingMultiplier;
    }
}
