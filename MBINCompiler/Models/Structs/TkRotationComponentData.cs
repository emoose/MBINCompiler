using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkRotationComponentData : NMSTemplate
    {
        public float Speed;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Axis;
    }
}
