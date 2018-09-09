namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9724C1F33A4A3060)]
    public class GcExpeditionPaymentToken : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TokenName;
        public int TokenValue;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
