using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x2)]
    public class Quaternion : NMSTemplate
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Quaternion() { }

        /// <summary>
        /// Returns a formatted string for this quaternion.
        /// <br/>Format: (x, y, z, w)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.x}, {this.y}, {this.z}, {this.w})";
        }
    }
}
