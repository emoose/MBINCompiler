using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF9044903B4B2CDD3)]
    public class GcMissionConditionInventorySlots : NMSTemplate
    {
		public enum InventoryTestEnum { Current, personal, Ship, Vehicle }
		public InventoryTestEnum InventoryTest;
        public int SlotsFree;
        public TkEqualityEnum Test;
    }
}
