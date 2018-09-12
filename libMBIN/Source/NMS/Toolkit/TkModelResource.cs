namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x83447CE313934E8F)]
    public class TkModelResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
