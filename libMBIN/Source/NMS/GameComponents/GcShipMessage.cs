namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EAECF620845E40EE)]
    public class GcShipMessage : NMSTemplate
    {
		public enum MessageTypeEnum { Leave, Fight }
		public MessageTypeEnum MessageType;
    }
}
