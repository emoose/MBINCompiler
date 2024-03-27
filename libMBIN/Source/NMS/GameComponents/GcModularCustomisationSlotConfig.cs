using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18F7A66D01714010, NameHash = 0xAA6A73C6FF45C9F8)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SlotID;
        /* 0x10 */ public NMSString0x20A LabelLocID;
        /* 0x30 */ public bool IncludeInSeed;
        /* 0x34 */ public float UILineLengthFactor;
        /* 0x38 */ public float UILineMinAngle;
        /* 0x3C */ public NMSString0x20 UILocatorName;
        /* 0x5C */ public Vector2f UISlotPosition;
        /* 0x68 */ public NMSString0x10 UISlotGraphicLayer;
        /* 0x78 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        /* 0xA8 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
    }
}
