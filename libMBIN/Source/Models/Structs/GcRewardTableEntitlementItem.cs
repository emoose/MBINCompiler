namespace libMBIN.Models.Structs
{
    public class GcRewardTableEntitlementItem : NMSTemplate     // size: 0x78
    {
        [NMS(Size = 0x10)]
        public string RewardId;
        [NMS(Size = 0x20)]
        public string EntitlementId;
        public NMSTemplate Reward;
    }
}
