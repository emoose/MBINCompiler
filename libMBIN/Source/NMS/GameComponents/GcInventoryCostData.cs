using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC803336C99E965D9, NameHash = 0x891585A60DC0D014)]
    public class GcInventoryCostData : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public GcInventoryCostDataEntry[] InventoryCostData;
    }
}
