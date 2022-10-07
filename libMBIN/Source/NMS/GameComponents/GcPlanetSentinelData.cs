namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC6C66FA5075980E, NameHash = 0x1EB5C4AE3BDB484E)]
    public class GcPlanetSentinelData : NMSTemplate
    {
        // size: 0x3
        public enum SentinelLevelEnum {
            Low,
            Default,
            Aggressive
        }
        /* 0x0 */ public SentinelLevelEnum SentinelLevel;
        /* 0x4 */ public int MaxActiveDrones;
    }
}
