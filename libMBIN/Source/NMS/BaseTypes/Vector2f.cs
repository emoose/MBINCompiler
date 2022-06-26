using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x8, Alignment = 0x4)]
    public class Vector2f : NMSTemplate
    {
        public float x;
        public float y;

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2f() { }

        /// <summary>
        /// Returns a formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
