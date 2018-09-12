namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x68, GUID = 0x85B887A3C1D9BD55)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RewardId;
        [NMS(Size = 0x10)]
        public string EntitlementId;
        public NMSTemplate Reward;
    }
}
