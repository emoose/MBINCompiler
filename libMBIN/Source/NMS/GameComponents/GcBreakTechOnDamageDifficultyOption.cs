namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6DDE6D23B8B28B3, NameHash = 0x1858CF2F851302AE)]
    public class GcBreakTechOnDamageDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum BreakTechOnDamageProbabilityEnum {
            None,
            Low,
            High,
        }
        /* 0x0 */ public BreakTechOnDamageProbabilityEnum BreakTechOnDamageProbability;
    }
}
