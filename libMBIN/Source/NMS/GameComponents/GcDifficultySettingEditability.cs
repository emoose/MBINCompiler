namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFD14EFAFB8CD283, NameHash = 0x215639935EEC2DFE)]
    public class GcDifficultySettingEditability : NMSTemplate
    {
        // size: 0x5
        public enum DifficultySettingEditabilityEnum {
            FullyEditable,
            IncreaseOnly,
            DecreaseOnly,
            LockedVisible,
            LockedHidden
        }
        /* 0x0 */ public DifficultySettingEditabilityEnum DifficultySettingEditability;
    }
}
