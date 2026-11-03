namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB16A971F7C5C98BA, NameHash = 0xB0ECA3FA)]
    public class GcInventoryStackLimitsDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum InventoryStackLimitsDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryStackLimitsDifficultyEnum InventoryStackLimitsDifficulty;
    }
}
