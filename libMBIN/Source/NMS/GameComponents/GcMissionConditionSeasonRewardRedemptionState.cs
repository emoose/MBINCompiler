using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC42AFEC01F54DF2B, NameHash = 0x33E6F9E7246B91A7)]
    public class GcMissionConditionSeasonRewardRedemptionState : NMSTemplate
    {
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        /* 0x4 */ public GcSeasonEndRewardsRedemptionState RewardRedempionState;
    }
}
