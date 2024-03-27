using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26EF81DE98F050DD, NameHash = 0x9F1240710CA7E631)]
    public class GcRewardStatDiff : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CoreStat;
        /* 0x10 */ public NMSString0x10 CompareAndSetStat;
        /* 0x20 */ public NMSString0x10 SubstanceID;
        /* 0x30 */ public GcCurrency RewardCurrency;
        /* 0x34 */ public int AmountPerStat;
        /* 0x38 */ public int StatRewardCap;
    }
}
