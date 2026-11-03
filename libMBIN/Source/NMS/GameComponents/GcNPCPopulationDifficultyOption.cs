namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB00940B085040C4, NameHash = 0xFD64B32A)]
    public class GcNPCPopulationDifficultyOption : NMSTemplate
    {
        // size: 0x2
        public enum NPCPopulationDifficultyEnum : uint {
            Full,
            Abandoned,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCPopulationDifficultyEnum NPCPopulationDifficulty;
    }
}
