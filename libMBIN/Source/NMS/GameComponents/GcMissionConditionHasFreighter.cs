namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75FFC8F79321C510, NameHash = 0x8563E3CD9630D9C)]
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
