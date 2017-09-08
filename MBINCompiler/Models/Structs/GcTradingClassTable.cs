namespace MBINCompiler.Models.Structs
{
    public class GcTradingClassTable : NMSTemplate      // size: 0xAAC
    {
        [NMS(Size = 0x7, EnumValue = new string[7] {"Mining", "HighTech", "Trading", "Manufacturing",
                                                    "Fusion" ,"Scientific", "PowerGeneration" })]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        [NMS(Size = 0x8, EnumValue = new string[8] {"Mineral", "Tech", "Commodity", "Component",
                                                    "Alloy", "Exotic", "Energy", "None" })]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xAA4 */ public float MaxTradingMultiplier;
        /* 0xAA8 */ public float MinTradingMultiplier;
    }
}
