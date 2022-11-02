namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E2FD9E9B0DB4DB7, NameHash = 0xCDF3A507A47FCD3)]
    public class GcDamageGivenDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum DamageGivenDifficultyEnum {
            High,
            Normal,
            Low
        }
        /* 0x0 */ public DamageGivenDifficultyEnum DamageGivenDifficulty;
    }
}
