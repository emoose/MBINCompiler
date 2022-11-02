using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B1BACC9BA0A93A3, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x420 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x578 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x6D0 */ public GcInventoryLayout InventoryLayout;
        /* 0x6F0 */ public ulong Location;
        /* 0x700 */ public Vector4f Position;
        /* 0x710 */ public Vector4f Direction;
    }
}
