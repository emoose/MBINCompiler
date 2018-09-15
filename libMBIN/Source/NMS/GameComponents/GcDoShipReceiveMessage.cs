using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCC6D793345BEFEDA)]
    public class GcDoShipReceiveMessage : NMSTemplate
    {
        public GcShipMessage ShipMessage;
    }
}
