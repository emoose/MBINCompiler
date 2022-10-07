namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8999C6C1FF778971, NameHash = 0x96CF7C217D988FDF)]
    public class GcActiveSurvivalBarsDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ActiveSurvivalBarsDifficultyEnum {
            None,
            HealthOnly,
            HealthAndHazard,
            All
        }
        /* 0x0 */ public ActiveSurvivalBarsDifficultyEnum ActiveSurvivalBarsDifficulty;
    }
}
