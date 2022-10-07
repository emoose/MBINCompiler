using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AAD82F7812779CF, NameHash = 0x66FAEFAF4E8E7167)]
    public class GcTradeData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;
        /* 0x20 */ public List<NMSString0x10> OptionalProducts;
        /* 0x30 */ public List<NMSString0x10> OptionalSubstances;
        /* 0x40 */ public int MinItemsForSale;
        /* 0x44 */ public int MaxItemsForSale;
        /* 0x48 */ public float PercentageOfItemsAreProducts;
        /* 0x4C */ public float BuyPriceIncreaseRedThreshold;
        /* 0x50 */ public float BuyPriceDecreaseGreenThreshold;
        /* 0x54 */ public float SellPriceIncreaseGreenThreshold;
        /* 0x58 */ public float SellPriceDecreaseRedThreshold;
        /* 0x5C */ public bool ShowSeasonRewards;
        // size: 0x4
        public enum MinAmountOfProductAvailableEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MinAmountOfProductAvailableEnum))]
        /* 0x60 */ public int[] MinAmountOfProductAvailable;
        // size: 0x4
        public enum MaxAmountOfProductAvailableEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxAmountOfProductAvailableEnum))]
        /* 0x70 */ public int[] MaxAmountOfProductAvailable;
        // size: 0x4
        public enum MinAmountOfSubstanceAvailableEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MinAmountOfSubstanceAvailableEnum))]
        /* 0x80 */ public int[] MinAmountOfSubstanceAvailable;
        // size: 0x4
        public enum MaxAmountOfSubstanceAvailableEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxAmountOfSubstanceAvailableEnum))]
        /* 0x90 */ public int[] MaxAmountOfSubstanceAvailable;
        // size: 0x4
        public enum MinExtraSystemProductsEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MinExtraSystemProductsEnum))]
        /* 0xA0 */ public int[] MinExtraSystemProducts;
        // size: 0x4
        public enum MaxExtraSystemProductsEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(MaxExtraSystemProductsEnum))]
        /* 0xB0 */ public int[] MaxExtraSystemProducts;
        // size: 0x4
        public enum TradeProductsPriceImprovementsEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(TradeProductsPriceImprovementsEnum))]
        /* 0xC0 */ public float[] TradeProductsPriceImprovements;
    }
}
