using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcTradeData : NMSTemplate       // size: 0x88
    {
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;

        /* 0x20 */ public int MinItemsForSale;
        /* 0x24 */ public int MaxItemsForSale;
        /* 0x28 */ public float PercentageOfItemsAreProducts;
        /* 0x2C */ public float MinEconomyInfluenceMultiplierForExtraProducts;
        /* 0x30 */ public float BuyPriceIncreaseRedThreshold;
        /* 0x34 */ public float BuyPriceDecreaseGreenThreshold;
        /* 0x38 */ public float SellPriceIncreaseGreenThreshold;
        /* 0x3C */ public float SellPriceDecreaseRedThreshold;
        [NMS(Size = 0x3)]
        /* 0x40 */ public int[] MinAmountOfProductAvailable;
        [NMS(Size = 0x3)]
        /* 0x4C */ public int[] MaxAmountOfProductAvailable;
        [NMS(Size = 0x3)]
        /* 0x58 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Size = 0x3)]
        /* 0x64 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Size = 0x3)]
        /* 0x70 */ public int[] MinExtraSystemProducts;
        [NMS(Size = 0x3)]
        /* 0x7C */ public int[] MaxExtraSystemProducts;
    }
}
