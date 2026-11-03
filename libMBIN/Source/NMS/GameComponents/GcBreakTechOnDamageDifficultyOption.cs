namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA857372866541ED7, NameHash = 0x7C892EED)]
    public class GcBreakTechOnDamageDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum BreakTechOnDamageProbabilityEnum : uint {
            None,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BreakTechOnDamageProbabilityEnum BreakTechOnDamageProbability;
    }
}
