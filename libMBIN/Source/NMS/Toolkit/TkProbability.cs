namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA47E5AFAD2782829, NameHash = 0xB0EA1B7F)]
    public class TkProbability : NMSTemplate
    {
        // size: 0x4
        public enum ProbabilityEnum : uint {
            Common,
            Uncommon,
            Rare,
            Extraordinary,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProbabilityEnum Probability;
    }
}
