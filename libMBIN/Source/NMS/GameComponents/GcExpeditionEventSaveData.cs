using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6B3E5D5803B3967, NameHash = 0xA95CE4EF897F62B2)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public ulong UA;
        /* 0x018 */ public List<int> AffectedFrigateIndices;
        /* 0x028 */ public List<int> RepairingFrigateIndices;
        /* 0x038 */ public List<int> AffectedFrigateResponses;
        /* 0x048 */ public NMSString0x20A EventID;
        /* 0x068 */ public NMSString0x20A InterventionEventID;
        /* 0x088 */ public NMSString0x40 OverriddenDescription;
        /* 0x0C8 */ public bool WhaleEvent;
        /* 0x0D0 */ public NMSString0x10 OverriddenReward;
        /* 0x0E0 */ public NMSString0x20A OverriddenRewardDescription;
        /* 0x100 */ public bool Success;
        /* 0x101 */ public bool IsInterventionEvent;
        /* 0x102 */ public bool AvoidedIntervention;
    }
}
