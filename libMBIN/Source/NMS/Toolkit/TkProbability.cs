namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x91F4745D4236E2DB, NameHash = 0x291E526240E013CC)]
    public class TkProbability : NMSTemplate
    {
        // size: 0x4
        public enum ProbabilityEnum {
            Common,
            Uncommon,
            Rare,
            Extraordinary
        }
        /* 0x0 */ public ProbabilityEnum Probability;
    }
}
