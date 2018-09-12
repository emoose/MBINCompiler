using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x47AABCD48527D767)]
    public class GcInventorySpecialSlotType : NMSTemplate
    {
		public enum InventorySpecialSlotTypeEnum { Broken, TechOnly, Cargo }
		public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}
