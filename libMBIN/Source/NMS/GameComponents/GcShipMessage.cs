using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xEAECF620845E40EE, NameHash = 0x7D370752342BB815)]
    public class GcShipMessage : NMSTemplate
    {
		public enum MessageTypeEnum { Leave, Fight }
		public MessageTypeEnum MessageType;
    }
}