using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEED357A80A8B8E2B, NameHash = 0x16B41518)]
    public class GcCostMoney : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Cost;
        [NMS(Index = 1)]
        /* 0x4 */ public GcCurrency CostCurrency;
    }
}
