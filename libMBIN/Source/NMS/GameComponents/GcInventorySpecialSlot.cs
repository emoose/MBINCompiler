using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7172C7AE26B7A70A)]
    public class GcInventorySpecialSlot : NMSTemplate
    {
        public GcInventorySpecialSlotType Type;
        public GcInventoryIndex Index;
    }
}
