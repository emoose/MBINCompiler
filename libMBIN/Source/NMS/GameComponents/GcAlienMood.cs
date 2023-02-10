namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B1765D3EB30767E, NameHash = 0x9A637E59AB66BFB0)]
    public class GcAlienMood : NMSTemplate
    {
        // size: 0x9
        public enum MoodEnum {
            Neutral,
            Positive,
            VeryPositive,
            Negative,
            VeryNegative,
            Pity,
            Sad,
            Dead,
            Confused,
        }
        /* 0x0 */ public MoodEnum Mood;
    }
}
