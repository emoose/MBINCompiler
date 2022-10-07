namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE9115ED253C23F2, NameHash = 0xBC2BBF55EEB95C06)]
    public class GcInventoryStackLimitsDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum InventoryStackLimitsDifficultyEnum {
            High,
            Normal,
            Low
        }
        /* 0x0 */ public InventoryStackLimitsDifficultyEnum InventoryStackLimitsDifficulty;
    }
}
