using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA85AD37E4B652D7, NameHash = 0x2D97A37D)]
    public class GcMissionConditionSeasonRewardRedemptionState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSeasonEndRewardsRedemptionState RewardRedempionState;
    }
}
