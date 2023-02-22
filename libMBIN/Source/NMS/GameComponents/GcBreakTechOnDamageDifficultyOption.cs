namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C81FD0FE4E2CBFB, NameHash = 0x1858CF2F851302AE)]
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
