using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7255CE45949CD0D4, NameHash = 0xB2EA0121EEE71A2B)]
    public class GcInventorySpecialSlot : NMSTemplate
    {
        /* 0x0 */ public GcInventorySpecialSlotType Type;
        /* 0x4 */ public GcInventoryIndex Index;
    }
}
