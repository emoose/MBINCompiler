using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7CBC97F2A556B82, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcSeed Seed;
        /* 0x2D8 */ public GcInventoryContainer Inventory;
        /* 0x430 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x588 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x6E0 */ public GcInventoryLayout InventoryLayout;
        /* 0x700 */ public ulong Location;
        /* 0x710 */ public Vector4f Position;
        /* 0x720 */ public Vector4f Direction;
    }
}
