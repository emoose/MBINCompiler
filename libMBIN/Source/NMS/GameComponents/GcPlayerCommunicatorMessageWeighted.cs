namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x58, GUID = 0x63ADDD99AFB6D901)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        public GcPlayerCommunicatorMessage Message;
        public int Weighted;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
