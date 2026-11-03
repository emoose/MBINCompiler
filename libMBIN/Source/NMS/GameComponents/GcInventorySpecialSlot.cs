using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD5371CD9AFE659C, NameHash = 0x121EA38B)]
    public class GcInventorySpecialSlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInventoryIndex Index;
        [NMS(Index = 0)]
        /* 0x8 */ public GcInventorySpecialSlotType Type;
    }
}
