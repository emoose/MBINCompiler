using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    // used for XYZW and RGBA type vectors
    [NMS(Size = 0x10, Alignment = 0x10)]
    public class Vector4i : NMSTemplate
    {
        public uint X;
        public uint Y;
        public uint Z;
        public uint W;

        public Vector4i(uint x, uint y, uint z, uint w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public Vector4i() { }

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
