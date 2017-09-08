namespace MBINCompiler.Models.Structs
{
    public class GcTradingClassData : NMSTemplate       // size: 0x9C
    {
        /* 0x00 */ public GcTradeCategory Sells;
        /* 0x04 */ public GcTradeCategory Needs;
        /* 0x08 */ public float MinSellingPriceMultiplier;
        /* 0x0C */ public float MaxSellingPriceMultiplier;
        /* 0x10 */ public float MinBuyingPriceMultiplier;
        /* 0x14 */ public float MaxBuyingPriceMultiplier;
        /* 0x18 */ public TkTextureResource Icon;
    }
}
