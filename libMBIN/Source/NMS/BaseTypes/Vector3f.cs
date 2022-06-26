using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x10)]
    public class Vector3f : NMSTemplate
    {
        public float x;
        public float y;
        public float z;

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3f() { }

        /// <summary>
        /// Returns a formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
