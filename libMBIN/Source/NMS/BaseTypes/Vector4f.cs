using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    // used for XYZW and RGBA type vectors
    [NMS(Size = 0x10, Alignment = 0x10)]
    public class Vector4f : NMSTemplate
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4f(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Vector4f() { }

        /// <summary>
        /// Returns a formatted string for this vector.
        /// <br/>Format: (x, y, z, w)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.X}, {this.Y}, {this.Z}, {this.W})";
        }
    }
}
