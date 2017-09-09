using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcTradeData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;

        /* 0x20 */ public int MinItemsForSale;
        /* 0x24 */ public int MaxItemsForSale;
        /* 0x28 */ public float PercentageOfItemsAreProducts;
        /* 0x2C */ public float BuyPriceIncreaseRedThreshold;
        /* 0x30 */ public float BuyPriceDecreaseGreenThreshold;
        /* 0x34 */ public float SellPriceIncreaseGreenThreshold;
        /* 0x38 */ public float SellPriceDecreaseRedThreshold;
        [NMS(Size = 0x3)]
        /* 0x3C */ public int[] MinAmountOfProductAvailable;
        [NMS(Size = 0x3)]
        /* 0x48 */ public int[] MaxAmountOfProductAvailable;
        [NMS(Size = 0x3)]
        /* 0x54 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Size = 0x3)]
        /* 0x60 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Size = 0x3)]
        /* 0x6C */ public int[] MinExtraSystemProducts;
        [NMS(Size = 0x3)]
        /* 0x78 */ public int[] MaxExtraSystemProducts;
        [NMS(Size = 0x3)]
        /* 0x84 */ public float[] TradeProductsPriceImprovements;
    }
}
