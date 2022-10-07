namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3831A5BA50281050, NameHash = 0xADDED46314D20DE5)]
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
