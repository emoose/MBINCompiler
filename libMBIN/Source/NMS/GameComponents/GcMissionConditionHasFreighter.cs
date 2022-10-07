namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B55DA1A2BA483CF, NameHash = 0x8563E3CD9630D9C)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
        // size: 0x3
        public enum FreighterInCurrentSystemEnum {
            DontCare,
            Yes,
            No
        }
        /* 0x0 */ public FreighterInCurrentSystemEnum FreighterInCurrentSystem;
    }
}
