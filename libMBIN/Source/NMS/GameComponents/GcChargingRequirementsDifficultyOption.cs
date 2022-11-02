namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF60678649B66CF1A, NameHash = 0x5F6767A5FB0B2FEA)]
    public class GcChargingRequirementsDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ChargingRequirementsDifficultyEnum {
            None,
            Low,
            Normal,
            High
        }
        /* 0x0 */ public ChargingRequirementsDifficultyEnum ChargingRequirementsDifficulty;
    }
}
