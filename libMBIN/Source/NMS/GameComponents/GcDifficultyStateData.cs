using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89E56B960124B848, NameHash = 0x3A5178A6)]
    public class GcDifficultyStateData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcDifficultySettingsData Settings;
        [NMS(Index = 1)]
        /* 0x60 */ public GcDifficultyPresetType EasiestUsedPreset;
        [NMS(Index = 2)]
        /* 0x64 */ public GcDifficultyPresetType HardestUsedPreset;
        [NMS(Index = 0)]
        /* 0x68 */ public GcDifficultyPresetType Preset;
    }
}
