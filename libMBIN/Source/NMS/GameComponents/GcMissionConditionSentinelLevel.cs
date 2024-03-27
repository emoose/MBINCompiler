namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5BAAC45724E72FD, NameHash = 0xB45DF78C123D703E)]
    public class GcMissionConditionSentinelLevel : NMSTemplate
    {
        // size: 0x5
        public enum RequiredSentinelLevelEnum : uint {
            None,
            Low,
            Default,
            Aggressive,
            Corrupt,
        }
        /* 0x0 */ public RequiredSentinelLevelEnum RequiredSentinelLevel;
    }
}
