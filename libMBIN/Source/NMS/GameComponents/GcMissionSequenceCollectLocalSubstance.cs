using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D83CC274F0C9132, NameHash = 0xD0D744F61AB1E31B)]
    public class GcMissionSequenceCollectLocalSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A UseScanEventToDetermineLocation;
        /* 0xA0 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0xA4 */ public int Amount;
        /* 0xA8 */ public bool UseDefaultValue;
        /* 0xAC */ public float DefaultValueMultiplier;
        /* 0xB0 */ public bool WaitForSelected;
        /* 0xB1 */ public bool CanFormatObjectives;
        /* 0xB2 */ public bool FromNow;
        /* 0xB3 */ public bool CanSetIcon;
        /* 0xB4 */ public bool TakeAmountFromSeasonData;
        /* 0xB5 */ public NMSString0x80 DebugText;
    }
}
