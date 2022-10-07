using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC25D6C36073B1B3A, NameHash = 0xA98FDB01046545AD)]
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
