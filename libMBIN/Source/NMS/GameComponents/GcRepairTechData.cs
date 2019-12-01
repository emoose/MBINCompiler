using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A0, GUID = 0xDF0C3D4AC52C69D3, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x190 */ public int InventoryType;
        /* 0x194 */ public GcInventoryIndex InventoryIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x19C */ public byte[] EndPadding;
    }
}
