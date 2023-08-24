using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE986C52268A4B16, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x84 */ public bool UseDefaultValue;
        /* 0x88 */ public float DefaultValueMultiplier;
        /* 0x90 */ public NMSString0x10 Substance;
        /* 0xA0 */ public int AmountMin;
        /* 0xA4 */ public int AmountMax;
        /* 0xA8 */ public bool WaitForSelected;
        /* 0xA9 */ public bool CanSetIcon;
        /* 0xB0 */ public NMSString0x10 ForBuild;
        /* 0xC0 */ public NMSString0x10 ForRepair;
        /* 0xD0 */ public GcItemNeedPurpose Purpose;
        /* 0xD4 */ public bool FromNow;
        /* 0xD5 */ public bool TakeAmountFromSeasonData;
        /* 0xD6 */ public bool SearchCookingIngredients;
        /* 0xD7 */ public NMSString0x80 DebugText;
    }
}
