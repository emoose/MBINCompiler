using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81366F08AE6B4242, NameHash = 0x6E51E89E7E62BE51)]
    public class GcPersistentBaseDifficultyData : NMSTemplate
    {
        /* 0x0 */ public GcDifficultyPresetType DifficultyPreset;
        // size: 0x2
        [Flags]
        public enum PersistentBaseDifficultyFlagsEnum {
            None,
            Locked
        }
        /* 0x4 */ public PersistentBaseDifficultyFlagsEnum PersistentBaseDifficultyFlags;
    }
}
