namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B2224162A8931EAF)]
    public class TkAudioAnimTrigger : NMSTemplate // 0x98 bytes
    {
        [NMS(Size = 0x80)]
        public string Sound;
        [NMS(Size = 0x10)]
        public string Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }
}
