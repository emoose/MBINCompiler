using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcBirdData : NMSTemplate
    {
        public float FlapSpeedMax;
        public float FlapSpeedMin;
        public float FlapSpeed;
        public float FlapAccel;

        [NMS(Size = 0x80)]
        public string CircleAttractor;
    }
}
