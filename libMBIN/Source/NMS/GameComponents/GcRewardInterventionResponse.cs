namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5986F63D067E8C5, NameHash = 0xE5DE143F)]
    public class GcRewardInterventionResponse : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 InterveneWithMissionID;
        [NMS(Index = 1)]
        /* 0x10 */ public int BasePercentOfMissionChanceSuccess;
        // size: 0x6
        public enum ResponseTypeEnum : uint {
            DontIntervene,
            InterveneWithMission,
            MissionSuccess,
            MissionFailure,
            MissionAvoid,
            MissionChance,
        }
        [NMS(Index = 0)]
        /* 0x14 */ public ResponseTypeEnum ResponseType;
    }
}
