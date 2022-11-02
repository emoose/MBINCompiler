namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6EBF12975089317, NameHash = 0xB45DF78C123D703E)]
    public class GcMissionConditionSentinelLevel : NMSTemplate
    {
        // size: 0x4
        public enum RequiredSentinelLevelEnum {
            None,
            Low,
            Default,
            Aggressive
        }
        /* 0x0 */ public RequiredSentinelLevelEnum RequiredSentinelLevel;
    }
}
