namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x968D796CF16400E)]
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Reference;
        [NMS(Size = 0x80)]
        public string LSystem;
    }
}
