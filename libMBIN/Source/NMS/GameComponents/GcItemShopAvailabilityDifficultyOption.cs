namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x989CAEDD60633BD2, NameHash = 0x9E64FF6ABCCC176A)]
    public class GcItemShopAvailabilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum ItemShopAvailabilityDifficultyEnum {
            High,
            Normal,
            Low,
        }
        /* 0x0 */ public ItemShopAvailabilityDifficultyEnum ItemShopAvailabilityDifficulty;
    }
}
