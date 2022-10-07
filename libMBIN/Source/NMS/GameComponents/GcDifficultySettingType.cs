namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC484F8322441039, NameHash = 0xFD8A2B15F29A9D3C)]
    public class GcDifficultySettingType : NMSTemplate
    {
        // size: 0x2
        public enum DifficultySettingTypeEnum {
            Toggle,
            OptionList
        }
        /* 0x0 */ public DifficultySettingTypeEnum DifficultySettingType;
    }
}
