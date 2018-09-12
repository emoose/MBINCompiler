namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9A55EA80BBEF4621)]
    public class TkAnimPoseData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public int FrameEnd;
    }
}
