using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEAECF620845E40EE)]
    public class GcShipMessage : NMSTemplate
    {
		public enum MessageTypeEnum { Leave, Fight }
		public MessageTypeEnum MessageType;
    }
}
