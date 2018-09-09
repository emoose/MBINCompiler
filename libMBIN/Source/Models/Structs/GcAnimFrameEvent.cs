namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x81EFA1D4D693E25A)]
    public class GcAnimFrameEvent : NMSTemplate     // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public bool StartFromEnd;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
