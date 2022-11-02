namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E84045D76A58739, NameHash = 0x81A38020A4FC78BE)]
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
