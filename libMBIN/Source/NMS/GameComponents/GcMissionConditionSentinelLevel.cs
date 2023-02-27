namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF04E8DDD3E651FB, NameHash = 0xB45DF78C123D703E)]
    public class GcMissionConditionSentinelLevel : NMSTemplate
    {
        // size: 0x4
        public enum RequiredSentinelLevelEnum : uint {
            None,
            Low,
            Default,
            Aggressive,
        }
        /* 0x0 */ public RequiredSentinelLevelEnum RequiredSentinelLevel;
    }
}
