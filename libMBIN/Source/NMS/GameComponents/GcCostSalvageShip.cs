using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0F285FA0341B935, NameHash = 0x94BADD03)]
    public class GcCostSalvageShip : NMSTemplate
    {
        [NMS(Index = 2, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x000 */ public NMSString0x20A[] CustomErrorMessageOSD;
        [NMS(Index = 1, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x180 */ public NMSString0x20A[] ShipClassStringOverride;
        [NMS(Index = 3)]
        /* 0x300 */ public bool CannotAffordIfStringOverrideIsNull;
        [NMS(Index = 0)]
        /* 0x301 */ public bool WillGiveShipParts;
    }
}
