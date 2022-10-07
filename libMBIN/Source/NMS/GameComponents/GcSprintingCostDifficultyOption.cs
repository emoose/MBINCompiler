namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE876539F9A5A1AB3, NameHash = 0x81A38020A4FC78BE)]
    public class GcSprintingCostDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum SprintingCostDifficultyEnum {
            Free,
            Low,
            Full
        }
        /* 0x0 */ public SprintingCostDifficultyEnum SprintingCostDifficulty;
    }
}
