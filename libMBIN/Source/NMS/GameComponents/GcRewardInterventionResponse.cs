namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7105FB962302E74C, NameHash = 0x3E904C2466567A08)]
    public class GcRewardInterventionResponse : NMSTemplate
    {
        // size: 0x6
        public enum ResponseTypeEnum : uint {
            DontIntervene,
            InterveneWithMission,
            MissionSuccess,
            MissionFailure,
            MissionAvoid,
            MissionChance,
        }
        /* 0x0 */ public ResponseTypeEnum ResponseType;
        /* 0x4 */ public int BasePercentOfMissionChanceSuccess;
        /* 0x8 */ public NMSString0x10 InterveneWithMissionID;
    }
}
