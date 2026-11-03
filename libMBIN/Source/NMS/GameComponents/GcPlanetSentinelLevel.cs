namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B072D66EA3D9659, NameHash = 0x75DF42CC)]
    public class GcPlanetSentinelLevel : NMSTemplate
    {
        // size: 0x4
        public enum SentinelLevelEnum : uint {
            Low,
            Default,
            Aggressive,
            Corrupt,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelLevelEnum SentinelLevel;
    }
}
