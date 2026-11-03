namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB5439871EA17642, NameHash = 0x630CBCC5)]
    public class GcStatsValueTypes : NMSTemplate
    {
        // size: 0x4
        public enum StatsValueEnum : uint {
            DistanceJetpacked,
            DistanceWalked,
            DistanceWarped,
            DamageSustained,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatsValueEnum StatsValue;
    }
}
