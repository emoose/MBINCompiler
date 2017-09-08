using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryContainer : NMSTemplate // 0x60 bytes
    {
        /* 0x00 */ public List<GcInventoryElement> Slots;
        /* 0x10 */ public List<GcInventoryIndex> ValidSlotIndices;
        /* 0x20 */ public GcInventoryClass Class;
        /* 0x24 */ public int SubstanceMaxStorageMultiplier;
        /* 0x28 */ public int ProductMaxStorageMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        /* 0x30 */ public List<GcInventoryBaseStatEntry> BaseStatValues;            // probably...
        /* 0x40 */ public List<GcInventorySpecialSlot> SpecialSlots;
        /* 0x50 */ public int Width;
        /* 0x54 */ public int Height;
        /* 0x58 */ public bool IsCool;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x59 */ public byte[] Padding59;
        /* 0x5C */ public int Version;
    }
}
