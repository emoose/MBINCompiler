namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA79B17D0FFE9ECFB, NameHash = 0x27C5678B5AA766C2)]
    public class GcRewardScanEventOutcome : NMSTemplate
    {
        // size: 0x7
        public enum RewardScanEventOutcomeEnum {
            Success,
            Interstellar,
            BadData,
            FailedToFindBase,
            Duplicate,
            NoBuilding,
            NoSystem
        }
        /* 0x0 */ public RewardScanEventOutcomeEnum RewardScanEventOutcome;
    }
}
