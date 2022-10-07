using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74CBF3173510C009, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x198 */ public int InventoryType;
        /* 0x19C */ public int InventorySubIndex;
        /* 0x1A0 */ public GcInventoryIndex InventoryIndex;
    }
}
