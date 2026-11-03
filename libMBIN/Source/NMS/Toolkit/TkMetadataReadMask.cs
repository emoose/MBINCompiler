using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF8AD15E0C4378ADD, NameHash = 0x11C23A82)]
    public class TkMetadataReadMask : NMSTemplate
    {
        // size: 0x6
        [Flags]
        public enum MetadataReadMaskEnum : uint {
            None = 0x0,
            Default = 0x1,
            SaveWhenMultiplayerClient = 0x2,
            SavePlayerPosition = 0x4,
            SavePlayerInventory = 0x8,
            SaveDifficultySettings = 0x10,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MetadataReadMaskEnum MetadataReadMask;
    }
}
