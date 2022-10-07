namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5C79A460E62BA23, NameHash = 0xA394F90C4AED36BD)]
    public class GcReputationGainDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ReputationGainDifficultyEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        /* 0x0 */ public ReputationGainDifficultyEnum ReputationGainDifficulty;
    }
}
