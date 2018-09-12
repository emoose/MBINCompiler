using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x42D5E0C093493E60)]
    public class GcInventoryClass : NMSTemplate
    {
		public enum InventoryClassEnum { C, B, A, S }
		public InventoryClassEnum InventoryClass;
    }
}
