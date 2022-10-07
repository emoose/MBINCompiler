namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55E9A3E9AB291B71, NameHash = 0x9E64FF6ABCCC176A)]
    public class GcItemShopAvailabilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum ItemShopAvailabilityDifficultyEnum {
            High,
            Normal,
            Low
        }
        /* 0x0 */ public ItemShopAvailabilityDifficultyEnum ItemShopAvailabilityDifficulty;
    }
}
