using libMBIN.Source.Common;
using System;

namespace libMBIN.NMS
{
    /// <summary>
    /// This class is a simple colour one. The values of each field must be between 0 and 1.
    /// To convert from the usual representation of a value between 0 and 255, you just need to divide the value
    /// by 255 to get the floating point representation used by the game.
    /// </summary>
    [NMS(Alignment = 0x4, Size = 0x4)]
    public class Colour32 : NMSTemplate
    {
        /// <summary>
        /// The Red component of the colour.
        /// </summary>
        public byte R;

        /// <summary>
        /// The Green component of the colour.
        /// </summary>
        public byte G;

        /// <summary>
        /// The Blue component of the colour.
        /// </summary>
        public byte B;

        /// <summary>
        /// The Alpha component of the colour.
        /// </summary>
        public byte A;


        /// <summary>
        /// Creates a Colour while providing it with float RGB values.
        /// <br/>Values must be between 0 - 1.
        /// </summary>
        /// <param name="R">Red component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="G">Green component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="B">Blue component of the colour. Value can be anything between 0 and 1.</param>
        /// <param name="A">Alpha component of the colour. Value can be anything between 0 and 1.</param>
        public Colour32(float R, float G, float B, float A = 1f)
        {
            this.R = (byte)(R * 255f);
            this.G = (byte)(G * 255f);
            this.B = (byte)(B * 255f);
            this.A = (byte)(A * 255f);
        }

        /// <summary>
        /// Creates a Colour while providing it with standard RGB values.
        /// <br/>Values must be whole numbers between 0 - 255.
        /// </summary>
        /// <param name="R">Red component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="G">Green component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="B">Blue component of the colour. Value can be any whole number between 0 and 255.</param>
        /// <param name="A">Alpha component of the colour. Value can be any whole number between 0 and 255.</param>
        public Colour32(byte R, byte G, byte B, byte A = 255)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public Colour32(Colour col) {
            this.R = (byte)(col.R * 255f);
            this.G = (byte)(col.G * 255f);
            this.B = (byte)(col.B * 255f);
            this.A = (byte)(col.A * 255f);
        }

        public Colour32() { }
    }
}
