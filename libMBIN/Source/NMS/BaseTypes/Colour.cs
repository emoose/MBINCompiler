using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Alignment = 0x10, Size = 0x10)]
    [NMSDescription(
        @"This class is a simple colour one. The values of each field must be between 0 and 1.
        To convert from the usual representation of a value between 0 and 255, you just need to divide the value
        by 255 to get the floating point representation used by the game."
    )]
    public class Colour : NMSTemplate
    {
        [NMSDescription("The Red component of the colour")]
        public float R;
        [NMSDescription("The Green component of the colour")]
        public float G;
        [NMSDescription("The Blue component of the colour")]
        public float B;
        [NMSDescription("The Alpha component of the colour")]
        public float A;

        public Colour(float R, float G, float B, float A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public Colour() { }
    }
}
