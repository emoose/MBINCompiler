namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEC254F8F1CAAC33, NameHash = 0x608F120)]
    public class GcChargingRequirementsDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ChargingRequirementsDifficultyEnum : uint {
            None,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ChargingRequirementsDifficultyEnum ChargingRequirementsDifficulty;
    }
}
