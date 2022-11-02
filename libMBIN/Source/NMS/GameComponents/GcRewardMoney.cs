using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE65288EF0B42A36D, NameHash = 0x2B59E601DE0BDEF9)]
    public class GcRewardMoney : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public bool RoundNumber;
        /* 0xC */ public GcCurrency Currency;
    }
}
