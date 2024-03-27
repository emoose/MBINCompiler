using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39FA18D3EA1B3F1B, NameHash = 0x9A04247FE2D03F05)]
    public class GcCostSalvageShip : NMSTemplate
    {
        /* 0x000 */ public bool WillGiveShipParts;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x008 */ public NMSString0x20A[] ShipClassStringOverride;
        /* 0x148 */ public bool CannotAffordIfStringOverrideIsNull;
    }
}
