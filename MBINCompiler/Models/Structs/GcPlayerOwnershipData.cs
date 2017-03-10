namespace MBINCompiler.Models.Structs
{
    public class GcPlayerOwnershipData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x328 */ public GcInventoryLayout InventoryLayout;
        /* 0x348 */ public ulong Location;
        /* 0x350 */ public Vector4f Position;
        /* 0x360 */ public Vector4f Direction;
    }
}
