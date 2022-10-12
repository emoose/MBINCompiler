using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59F1AA2A505F8672, NameHash = 0x814973F0DDEB62C8)]
    public class GcDifficultyStateData : NMSTemplate
    {
        /* 0x0 */ public GcDifficultyPresetType Preset;
        /* 0x4 */ public GcDifficultyPresetType EasiestUsedPreset;
        /* 0x8 */ public GcDifficultySettingsData Settings;
    }
}
