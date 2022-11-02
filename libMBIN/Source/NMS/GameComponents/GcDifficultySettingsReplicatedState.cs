using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F64A44E4291E4C9, NameHash = 0xAE3AC9A3967B8330)]
    public class GcDifficultySettingsReplicatedState : NMSTemplate
    {
        /* 0x00 */ public bool IsPermadeath;
        /* 0x04 */ public GcDifficultyPresetType Preset;
        /* 0x08 */ public GcDifficultyPresetType RoundedDownPreset;
        /* 0x0C */ public GcDifficultyPresetType EasiestUsedPreset;
        /* 0x10 */ public GcDifficultyPresetType HardestUsedPreset;
        /* 0x14 */ public bool IsLocked;
    }
}
