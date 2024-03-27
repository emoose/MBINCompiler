namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66BA958712233783, NameHash = 0x728CF5B9DDC60AD4)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RewardId;
        /* 0x10 */ public NMSString0x10 EntitlementId;
        /* 0x20 */ public NMSTemplate Reward;
    }
}
