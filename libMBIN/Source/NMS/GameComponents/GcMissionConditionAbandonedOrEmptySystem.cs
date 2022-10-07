namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34E46A2140A63B57, NameHash = 0x651218B208D538A0)]
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
