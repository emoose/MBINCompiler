using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x336C024001BFA1B3, NameHash = 0x814973F0DDEB62C8)]
    public class GcDifficultyStateData : NMSTemplate
    {
        /* 0x0 */ public GcDifficultyPresetType Preset;
        /* 0x4 */ public GcDifficultyPresetType EasiestUsedPreset;
        /* 0x8 */ public GcDifficultyPresetType HardestUsedPreset;
        /* 0xC */ public GcDifficultySettingsData Settings;
    }
}
