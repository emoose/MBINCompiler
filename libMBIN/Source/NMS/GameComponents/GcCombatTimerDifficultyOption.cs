namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD4DA7E7E659817, NameHash = 0xF407DE9312D729B0)]
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
