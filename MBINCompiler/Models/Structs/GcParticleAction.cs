using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcParticleAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Effect;
        [NMS(Size = 0x20)]
        public string Joint;
        public bool Exact;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding31;
    }
}
