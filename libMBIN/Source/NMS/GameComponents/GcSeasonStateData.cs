using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52DA52ECE795581F, NameHash = 0x4BC716CF849F5A74)]
    public class GcSeasonStateData : NMSTemplate
    {
        /* 0x00 */ public List<float> MilestoneValues;
        /* 0x10 */ public List<short> RewardCollected;
        /* 0x20 */ public int PinnedStage;
        /* 0x24 */ public int PinnedMilestone;
        /* 0x28 */ public List<ulong> RendezvousUAs;
        /* 0x38 */ public bool HasCollectedFinalReward;
        /* 0x40 */ public List<GcUAProtectedLocations> ProtectedEvents;
        /* 0x50 */ public GcSeasonSaveStateOnDeath StateOnDeath;
    }
}
