using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A3B3FB15EA7549F, NameHash = 0x5E0E55BB)]
    public class GcDifficultyCurrencyCostOptionData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcCurrency.CurrencyEnum))]
        /* 0x00 */ public float[] Multipliers;
        [NMS(Index = 2)]
        /* 0x0C */ public float TradeBuyPriceMarkupMod;
        // size: 0x3
        public enum FreeCostTypesEnum {
            Currency,
            Substance,
            Product,
        }
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(FreeCostTypesEnum))]
        /* 0x10 */ public bool[] FreeCostTypes;
        [NMS(Index = 4)]
        /* 0x13 */ public bool CostManagerCostsAreFree;
        [NMS(Index = 3)]
        /* 0x14 */ public bool InteractionsCostsAreFree;
    }
}
