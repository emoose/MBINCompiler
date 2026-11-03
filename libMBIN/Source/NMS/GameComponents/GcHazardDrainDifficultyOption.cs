namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1610A62C9A20185B, NameHash = 0xB865E9CD)]
    public class GcHazardDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum HazardDrainDifficultyEnum : uint {
            Slow,
            Normal,
            Fast,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardDrainDifficultyEnum HazardDrainDifficulty;
    }
}
