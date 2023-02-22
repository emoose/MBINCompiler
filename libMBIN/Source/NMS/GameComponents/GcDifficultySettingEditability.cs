namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADB5701EE17E9176, NameHash = 0x215639935EEC2DFE)]
    public class GcDifficultySettingEditability : NMSTemplate
    {
        // size: 0x5
        public enum DifficultySettingEditabilityEnum {
            FullyEditable,
            IncreaseOnly,
            DecreaseOnly,
            LockedVisible,
            LockedHidden,
        }
        /* 0x0 */ public DifficultySettingEditabilityEnum DifficultySettingEditability;
    }
}
