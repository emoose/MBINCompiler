using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAnimPoseCorrelationData : NMSTemplate // 0x28 bytes
    {
        [NMS(Size = 0x10)]
        public string ItemA;
        [NMS(Size = 0x10)]
        public string ItemB;
        public float Correlation;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }
}
