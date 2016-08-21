using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkNGuiGraphicStyleData :NMSTemplate
    {
        public float PddingX;
        public float PddingY;
        public float MarginX;
        public float MarginY;
        public Colour Colour;
        public Colour IconColour;
        public Colour StrokeColour;
        public int Shape;

        public string[] ShapeValues()
        { return new string[] { "Rectangle", "Ellipse" }; }


        public bool SolidColour;
        public bool HasDropShadow;
        public bool HasOuterGradient;
        public bool HasInnerGradient;
        public int Gradient;

        public string[] GradientValues()
        { return new string[] { "None", "Vertical", "Horizontal" }; }


        public float GradientStartOffset;
        public float GradientEndOffset;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0xC )]
        public byte[] Padding1;

        public Colour GradientColour;
        public float CornerRadius;
        public float StrokeSize;
        public int Image;
        public int Icon;
    }
}
