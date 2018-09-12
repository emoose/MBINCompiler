using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x8EFB720F2049EC27, Broken = true)]
    public class GcRepairTechData : NMSTemplate
    {
        public GcMaintenanceContainer MaintenanceContainer;
        public int InventoryType;
        public GcInventoryIndex InventoryIndex;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
