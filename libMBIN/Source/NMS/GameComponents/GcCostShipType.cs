using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A0ECF884AEF2420, NameHash = 0xC61E1F77)]
    public class GcCostShipType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSpaceshipClasses ShipType;
    }
}
