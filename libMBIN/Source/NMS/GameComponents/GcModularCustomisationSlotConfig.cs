using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C1F7A1BFBEA7760, NameHash = 0xE45C3809)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public GcModularCustomisationSlotItemData SlotEmptyFinalCustomisation;
        [NMS(Index = 9)]
        /* 0x040 */ public GcModularCustomisationSlotItemData SlotEmptyPreviewCustomisation;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x20A LabelLocID;
        [NMS(Index = 12)]
        /* 0x0A0 */ public List<NMSString0x10> AdditionalSlottableItemLists;
        [NMS(Index = 8)]
        /* 0x0B0 */ public List<NMSString0x20> AssociatedNonProcNodes;
        [NMS(Index = 0)]
        /* 0x0C0 */ public NMSString0x10 SlotID;
        [NMS(Index = 11)]
        /* 0x0D0 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
        [NMS(Index = 7)]
        /* 0x0E0 */ public NMSString0x10 UISlotGraphicLayer;
        [NMS(Index = 6)]
        /* 0x0F0 */ public Vector2f UISlotPosition;
        [NMS(Index = 3)]
        /* 0x0F8 */ public float UILineLengthFactor;
        [NMS(Index = 4)]
        /* 0x0FC */ public float UILineMaxAngle;
        [NMS(Index = 5)]
        /* 0x100 */ public NMSString0x20 UILocatorName;
        [NMS(Index = 2)]
        /* 0x120 */ public bool IncludeInSeed;
    }
}
