namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x823AE29E15FFFDA5, NameHash = 0x66CF327A)]
    public class GcAlienMood : NMSTemplate
    {
        // size: 0xA
        public enum MoodEnum : uint {
            Neutral,
            Positive,
            VeryPositive,
            Negative,
            VeryNegative,
            Pity,
            Sad,
            Dead,
            Confused,
            Busy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MoodEnum Mood;
    }
}
