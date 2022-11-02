namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B2228880488AAB, NameHash = 0xADDED46314D20DE5)]
    public class GcStatsAchievements : NMSTemplate
    {
        // size: 0x2
        public enum StatsAchievementsEnum {
            FirstWarp,
            FirstDiscovery
        }
        /* 0x0 */ public StatsAchievementsEnum StatsAchievements;
    }
}
