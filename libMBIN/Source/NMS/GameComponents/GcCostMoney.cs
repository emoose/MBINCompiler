using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4026147B653FA529, NameHash = 0x512506C3685B14E6)]
    public class GcCostMoney : NMSTemplate
    {
        /* 0x0 */ public int Cost;
        /* 0x4 */ public GcCurrency CostCurrency;
    }
}
