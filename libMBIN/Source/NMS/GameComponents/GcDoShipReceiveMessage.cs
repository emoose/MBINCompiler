using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC6D793345BEFEDA, NameHash = 0x7259326795A5F942)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        /* 0x0 */ public GcShipMessage ShipMessage;
    }
}
