using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0D879F08A5B3064, NameHash = 0x6E51E89E7E62BE51)]
    public class GcPersistentBaseDifficultyData : NMSTemplate
    {
        /* 0x0 */ public GcDifficultyPresetType DifficultyPreset;
        // size: 0x2
        public enum PersistentBaseDifficultyFlagsEnum {
            None,
            Locked
        }
        /* 0x4 */ public PersistentBaseDifficultyFlagsEnum PersistentBaseDifficultyFlags;
    }
}
