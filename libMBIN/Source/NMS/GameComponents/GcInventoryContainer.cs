using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3FAA4D01E70C02D, NameHash = 0xAF875892F81EDE11)]
    public class GcInventoryContainer : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryElement> Slots;
        /* 0x010 */ public List<GcInventoryIndex> ValidSlotIndices;
        /* 0x020 */ public GcInventoryClass Class;
        /* 0x024 */ public GcInventoryStackSizeGroup StackSizeGroup;
        /* 0x028 */ public List<GcInventoryBaseStatEntry> BaseStatValues;
        /* 0x038 */ public List<GcInventorySpecialSlot> SpecialSlots;
        /* 0x048 */ public int Width;
        /* 0x04C */ public int Height;
        /* 0x050 */ public bool IsCool;
        /* 0x051 */ public NMSString0x100 Name;
        /* 0x154 */ public int Version;
    }
}
