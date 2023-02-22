namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x421065E59E69DDC4, NameHash = 0x7D370752342BB815)]
    public class GcShipMessage : NMSTemplate
    {
        // size: 0x2
        public enum MessageTypeEnum {
            Leave,
            Fight,
        }
        /* 0x0 */ public MessageTypeEnum MessageType;
    }
}
