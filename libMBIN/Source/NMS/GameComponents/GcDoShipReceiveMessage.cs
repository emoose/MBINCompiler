using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FA2E7D59D7CC70A, NameHash = 0x88AA59E8)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcShipMessage ShipMessage;
    }
}
