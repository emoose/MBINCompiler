using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7142D10F99A9A2D5, NameHash = 0x9061069311B1AB2E)]
    public class GcDifficultyCurrencyCostOptionData : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcCurrency.CurrencyEnum))]
        /* 0x00 */ public float[] Multipliers;
        // size: 0x3
        public enum FreeCostTypesEnum {
            Currency,
            Substance,
            Product,
        }
        [NMS(Size = 0x3, EnumType = typeof(FreeCostTypesEnum))]
        /* 0x0C */ public bool[] FreeCostTypes;
        /* 0x10 */ public float TradeBuyPriceMarkupMod;
        /* 0x14 */ public bool InteractionsCostsAreFree;
        /* 0x15 */ public bool CostManagerCostsAreFree;
    }
}
