namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9E8977C498CF111F)]
    public class TkProceduralInstanceData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Index;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
