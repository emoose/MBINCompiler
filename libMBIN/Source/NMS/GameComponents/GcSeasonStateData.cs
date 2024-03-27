using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E883A1AE4717A59, NameHash = 0x4BC716CF849F5A74)]
    public class GcSeasonStateData : NMSTemplate
    {
        /* 0x000 */ public List<float> MilestoneValues;
        /* 0x010 */ public List<short> RewardCollected;
        /* 0x020 */ public int PinnedStage;
        /* 0x024 */ public int PinnedMilestone;
        /* 0x028 */ public List<ulong> RendezvousUAs;
        /* 0x038 */ public bool HasCollectedFinalReward;
        /* 0x040 */ public List<GcUAProtectedLocations> ProtectedEvents;
        /* 0x050 */ public GcSeasonSaveStateOnDeath StateOnDeath;
        /* 0x058 */ public GcInventoryContainer SeasonTransferInventory;
        /* 0x1B0 */ public GcSeasonEndRewardsRedemptionState EndRewardsRedemptionState;
    }
}
