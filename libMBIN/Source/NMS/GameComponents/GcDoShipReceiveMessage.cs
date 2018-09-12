using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0CC6D793345BEFEDA)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        public GcShipMessage ShipMessage;
    }
}
