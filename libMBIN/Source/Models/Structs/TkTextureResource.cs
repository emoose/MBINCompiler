namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8F308DA13045525E)]
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
