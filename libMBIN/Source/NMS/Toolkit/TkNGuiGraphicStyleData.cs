using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC0788C7616281900, NameHash = 0x93482A51)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x00 */ public TkNGuiGraphicAnimatedImageData Animated;
        [NMS(Index = 11, MxmlName = "Corner Radius")]
        /* 0x20 */ public float CornerRadius;
        [NMS(Index = 15)]
        /* 0x24 */ public float Desaturation;
        [NMS(Index = 14)]
        /* 0x28 */ public TkNGuiEditorIcons EditorIcon;
        [NMS(Index = 10, MxmlName = "Gradient End Offset")]
        /* 0x2C */ public float GradientEndOffset;
        [NMS(Index = 9, MxmlName = "Gradient Start Offset")]
        /* 0x30 */ public float GradientStartOffset;
        [NMS(Index = 13)]
        /* 0x34 */ public int Image;
        [NMS(Index = 7)]
        /* 0x38 */ public float MarginX;
        [NMS(Index = 8)]
        /* 0x3C */ public float MarginY;
        [NMS(Index = 5)]
        /* 0x40 */ public float PaddingX;
        [NMS(Index = 6)]
        /* 0x44 */ public float PaddingY;
        [NMS(Index = 17, MxmlName = "Stroke Gradient Feather")]
        /* 0x48 */ public float StrokeGradientFeather;
        [NMS(Index = 16, MxmlName = "Stroke Gradient Offset")]
        /* 0x4C */ public float StrokeGradientOffset;
        [NMS(Index = 12, MxmlName = "Stroke Size")]
        /* 0x50 */ public float StrokeSize;
        [NMS(Index = 0)]
        /* 0x54 */ public Colour32 Colour;
        [NMS(Index = 3, MxmlName = "Gradient Colour")]
        /* 0x58 */ public Colour32 GradientColour;
        [NMS(Index = 1, MxmlName = "Icon Colour")]
        /* 0x5C */ public Colour32 IconColour;
        [NMS(Index = 2, MxmlName = "Stroke Colour")]
        /* 0x60 */ public Colour32 StrokeColour;
        [NMS(Index = 4, MxmlName = "Stroke Gradient Colour")]
        /* 0x64 */ public Colour32 StrokeGradientColour;
        // size: 0x6
        public enum GradientEnum : byte {
            None,
            Vertical,
            Horizontal,
            HorizontalBounce,
            Radial,
            Box,
        }
        [NMS(Index = 19)]
        /* 0x68 */ public GradientEnum Gradient;
        [NMS(Index = 24, MxmlName = "Gradient Offset Percent")]
        /* 0x69 */ public bool GradientOffsetPercent;
        [NMS(Index = 21, MxmlName = "Has Drop Shadow")]
        /* 0x6A */ public bool HasDropShadow;
        [NMS(Index = 23, MxmlName = "Has Inner Gradient")]
        /* 0x6B */ public bool HasInnerGradient;
        [NMS(Index = 22, MxmlName = "Has Outer Gradient")]
        /* 0x6C */ public bool HasOuterGradient;
        // size: 0x8
        public enum ShapeEnum : byte {
            Rectangle,
            Ellipse,
            Line,
            LineInverted,
            Bezier,
            BezierInverted,
            BezierWide,
            BezierWideInverted,
        }
        [NMS(Index = 18)]
        /* 0x6D */ public ShapeEnum Shape;
        [NMS(Index = 20, MxmlName = "Solid Colour")]
        /* 0x6E */ public bool SolidColour;
        [NMS(Index = 25, MxmlName = "Stroke Gradient")]
        /* 0x6F */ public bool StrokeGradient;
    }
}
