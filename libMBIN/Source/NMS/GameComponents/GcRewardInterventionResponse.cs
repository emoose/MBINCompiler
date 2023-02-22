namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x985634C4BE6A9411, NameHash = 0x3E904C2466567A08)]
    public class GcRewardInterventionResponse : NMSTemplate
    {
        // size: 0x4
        public enum ResponseTypeEnum {
            DontIntervene,
            InterveneWithMission,
            MissionSuccess,
            MissionFailure,
        }
        /* 0x0 */ public ResponseTypeEnum ResponseType;
        /* 0x8 */ public NMSString0x10 MissionID;
    }
}
