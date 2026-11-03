using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B12F741EDAA0714, NameHash = 0x25B5370E)]
    public class GcShipInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public int[] MaxCargoInventoryCapacity;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x10 */ public int[] MaxInventoryCapacity;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x20 */ public int[] MaxTechInventoryCapacity;
    }
}
