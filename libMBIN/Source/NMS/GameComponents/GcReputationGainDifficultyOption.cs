namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1C84E30DF0BB69C, NameHash = 0xF985B8FD)]
    public class GcReputationGainDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ReputationGainDifficultyEnum : uint {
            VeryFast,
            Fast,
            Normal,
            Slow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ReputationGainDifficultyEnum ReputationGainDifficulty;
    }
}
