namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B60CF7D8AD0ADE1, NameHash = 0x4032F9F9)]
    public class GcGameTableMode : NMSTemplate
    {
        // size: 0x3
        public enum GameTableModeEnum : uint {
            Undecided,
            DiceGame,
            PetBattler,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GameTableModeEnum GameTableMode;
    }
}
