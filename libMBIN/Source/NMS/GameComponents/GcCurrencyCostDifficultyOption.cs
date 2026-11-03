namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65FFB60261D30F20, NameHash = 0x39C5AD99)]
    public class GcCurrencyCostDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum CurrencyCostDifficultyEnum : uint {
            Free,
            Cheap,
            Normal,
            Expensive,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CurrencyCostDifficultyEnum CurrencyCostDifficulty;
    }
}
