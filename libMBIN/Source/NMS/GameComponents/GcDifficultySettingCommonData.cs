using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F5B75DEFDD1C3C3, NameHash = 0xA98FDB01046545AD)]
    public class GcDifficultySettingCommonData : NMSTemplate
    {
        /* 0x00 */ public GcDifficultySettingType SettingType;
        /* 0x04 */ public bool IsAscendingDifficulty;
        /* 0x08 */ public GcDifficultySettingEditability EditabilityInOptionsMenu;
        /* 0x10 */ public NMSString0x20A TitleLocID;
        /* 0x30 */ public NMSString0x20A DescriptionLocID;
        /* 0x50 */ public NMSString0x20A ToggleEnabledLocID;
        /* 0x70 */ public NMSString0x20A ToggleDisabledLocID;
    }
}
