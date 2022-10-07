namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0EE7CB1B3FA0AF7, NameHash = 0x788E938DA3146A0E)]
    public class GcCurrencyCostDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum CurrencyCostDifficultyEnum {
            Free,
            Cheap,
            Normal,
            Expensive
        }
        /* 0x0 */ public CurrencyCostDifficultyEnum CurrencyCostDifficulty;
    }
}
