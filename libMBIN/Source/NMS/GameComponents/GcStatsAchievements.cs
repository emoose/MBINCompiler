namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x987885BC3B4BCF2F, NameHash = 0x50488306)]
    public class GcStatsAchievements : NMSTemplate
    {
        // size: 0x2
        public enum StatsAchievementsEnum : uint {
            FirstWarp,
            FirstDiscovery,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatsAchievementsEnum StatsAchievements;
    }
}
