namespace libMBIN.Models.Structs
{
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
