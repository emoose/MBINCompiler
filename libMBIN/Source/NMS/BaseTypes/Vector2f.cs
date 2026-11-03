using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x8, Alignment = 0x4)]
    public class Vector2f : NMSTemplate
    {
        public float X;
        public float Y;

        public Vector2f(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2f() { }

        /// <summary>
        /// Returns a formatted string for this vector.
        /// <br/>Format: (x, y)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
}
