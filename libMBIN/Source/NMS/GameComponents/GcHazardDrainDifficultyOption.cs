namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE462E2AFEC05C71, NameHash = 0x56BC170774FBDFB4)]
    public class GcHazardDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum HazardDrainDifficultyEnum {
            Slow,
            Normal,
            Fast
        }
        /* 0x0 */ public HazardDrainDifficultyEnum HazardDrainDifficulty;
    }
}
