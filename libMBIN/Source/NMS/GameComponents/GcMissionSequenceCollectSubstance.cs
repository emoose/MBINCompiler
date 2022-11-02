using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA78C6E818D81297, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x88 */ public NMSString0x10 Substance;
        /* 0x98 */ public int AmountMin;
        /* 0x9C */ public int AmountMax;
        /* 0xA0 */ public bool WaitForSelected;
        /* 0xA8 */ public NMSString0x10 ForBuild;
        /* 0xB8 */ public NMSString0x10 ForRepair;
        /* 0xC8 */ public GcItemNeedPurpose Purpose;
        /* 0xCC */ public bool FromNow;
        /* 0xCD */ public bool TakeAmountFromSeasonData;
        /* 0xCE */ public NMSString0x80 DebugText;
    }
}
