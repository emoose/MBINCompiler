using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4BB93E3F8F2AAAD, NameHash = 0x1920DA0CB7B61986)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ID;
        /* 0x020 */ public GcMissionType MissionType;
        /* 0x024 */ public int SelectionWeight;
        /* 0x028 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x02C */ public GcNumberedTextList InteractionID;
        /* 0x050 */ public NMSString0x20 SuccessLogEntry;
        /* 0x070 */ public NMSString0x20 AvoidanceSuccessLogEntry;
        /* 0x090 */ public NMSString0x20 AvoidanceFailureLogEntry;
        /* 0x0B0 */ public NMSString0x20 FailureLogEntry;
        /* 0x0D0 */ public NMSString0x10 SuccessReward;
        /* 0x0E0 */ public NMSString0x10 AvoidanceSuccessReward;
        /* 0x0F0 */ public NMSString0x10 AvoidanceFailureReward;
        /* 0x100 */ public NMSString0x10 FailureReward;
        /* 0x110 */ public int FailureDamageChance;
    }
}
