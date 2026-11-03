namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x482A81B0922363CB, NameHash = 0x8B7AE9E3)]
    public class GcGameTableAIDifficulty : NMSTemplate
    {
        // size: 0x3
        public enum GameTableAIDifficultyEnum : uint {
            Easy,
            Medium,
            Hard,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GameTableAIDifficultyEnum GameTableAIDifficulty;
    }
}
