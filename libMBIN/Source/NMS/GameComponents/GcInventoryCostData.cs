using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE566A753471E707, NameHash = 0x427DC96C)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
