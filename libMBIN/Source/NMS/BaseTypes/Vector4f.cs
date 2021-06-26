using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    // used for XYZW and RGBA type vectors
    [NMS(Size = 0x10, Alignment = 0x10)]
    public class Vector4f : NMSTemplate
    {
        public float x;
        public float y;
        public float z;
        // t is w in NMS.exe
        public float t;

        // t is w in NMS.exe
        public Vector4f(float x, float y, float z, float t)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            // t is w in NMS.exe
            this.t = t;
        }

        public Vector4f() { }
    }
}
