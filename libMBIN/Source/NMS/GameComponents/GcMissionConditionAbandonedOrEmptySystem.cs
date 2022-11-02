namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15776A9491BAFF8D, NameHash = 0x651218B208D538A0)]
    public class GcMissionConditionAbandonedOrEmptySystem : NMSTemplate
    {
        // size: 0x3
        public enum MissionSystemTypeEnum {
            Either,
            Empty,
            Abandoned
        }
        /* 0x0 */ public MissionSystemTypeEnum MissionSystemType;
    }
}
