using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3C8E4EAAD544694, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionProductEnum Default;
        /* 0x88 */ public NMSString0x10 Product;
        /* 0x98 */ public int AmountMin;
        /* 0x9C */ public int AmountMax;
        /* 0xA0 */ public bool WaitForSelected;
        /* 0xA8 */ public NMSString0x10 ForBuild;
        /* 0xB8 */ public NMSString0x10 ForRepair;
        /* 0xC8 */ public GcItemNeedPurpose Purpose;
        /* 0xCC */ public bool TeachIfNotKnown;
        /* 0xCD */ public bool FromNow;
        /* 0xCE */ public bool TakeAmountFromSeasonData;
        /* 0xCF */ public bool DependentOnSeasonMilestone;
        /* 0xD0 */ public NMSString0x80 DebugText;
    }
}
