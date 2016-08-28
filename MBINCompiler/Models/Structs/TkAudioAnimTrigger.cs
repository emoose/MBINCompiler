using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
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
