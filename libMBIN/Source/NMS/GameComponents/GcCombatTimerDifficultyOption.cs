namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F83B2C5B6F5E6D8, NameHash = 0xF407DE9312D729B0)]
    public class GcCombatTimerDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum CombatTimerDifficultyOptionEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        /* 0x0 */ public CombatTimerDifficultyOptionEnum CombatTimerDifficultyOption;
    }
}
