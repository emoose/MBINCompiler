namespace libMBIN.Models.Structs
{
    public class GcTradingClassTable : NMSTemplate      // size: 0xAAC
    {
        [NMS(Size = 0x7)]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        [NMS(Size = 0x8)]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xAA4 */ public float MaxTradingMultiplier;
        /* 0xAA8 */ public float MinTradingMultiplier;
    }
}
