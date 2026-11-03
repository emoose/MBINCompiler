using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x10)]
    public class Vector3f : NMSTemplate
    {
        public float X;
        public float Y;
        public float Z;
        public readonly float W = 1.0f;

        public Vector3f(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3f() { }

        /// <summary>
        /// Returns a formatted string for this vector.
        /// <br/>Format: (x, y, z)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.X}, {this.Y}, {this.Z})";
        }
    }
}
