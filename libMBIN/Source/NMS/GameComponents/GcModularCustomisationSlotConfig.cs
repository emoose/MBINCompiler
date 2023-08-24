using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x585AB4CE33BDBAA4, NameHash = 0xAA6A73C6FF45C9F8)]
    public class GcModularCustomisationSlotConfig : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SlotID;
        /* 0x10 */ public NMSString0x20A LabelLocID;
        /* 0x30 */ public bool IncludeInSeed;
        /* 0x38 */ public GcModularCustomisationSlotItemData SlotEmptyCustomisation;
        /* 0x58 */ public List<GcModularCustomisationSlotItemData> SlottableItems;
    }
}
