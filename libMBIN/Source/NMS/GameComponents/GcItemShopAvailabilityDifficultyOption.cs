namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4D0B040E1EF2EDE, NameHash = 0x1117CF1B)]
    public class GcItemShopAvailabilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum ItemShopAvailabilityDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ItemShopAvailabilityDifficultyEnum ItemShopAvailabilityDifficulty;
    }
}
