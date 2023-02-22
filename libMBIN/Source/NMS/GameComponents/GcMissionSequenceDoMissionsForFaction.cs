using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46580389AC072212, NameHash = 0xBDA9289A7DF468BD)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcFactionSelectOptions SelectFrom;
        /* 0x88 */ public int AmountMin;
        /* 0x8C */ public int AmountMax;
        /* 0x90 */ public NMSString0x80 DebugText;
    }
}
