namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75DFB0F0C3570AA3, NameHash = 0xCB7DBF48)]
    public class GcSeasonEndRewardsRedemptionState : NMSTemplate
    {
        // size: 0x4
        public enum SeasonEndRewardsRedemptionStateEnum : uint {
            None,
            Available,
            PendingRedemption,
            Redeemed,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SeasonEndRewardsRedemptionStateEnum SeasonEndRewardsRedemptionState;
    }
}
