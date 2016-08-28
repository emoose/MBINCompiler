using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcStateTimeEvent : NMSTemplate
    {
        public float Seconds;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
    }
}
