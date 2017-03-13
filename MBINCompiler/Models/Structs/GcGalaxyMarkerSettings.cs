namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyMarkerSettings : NMSTemplate       // size: 0x70
    {
        [NMS(Size = 3)]
        /* 0x00 */ public Colour[] Colours;

        /* 0x30 */ public Colour OutlineColour;
        /* 0x40 */ public float OutlineWidth;
        /* 0x44 */ public int EdgeCount;
        /* 0x48 */ public float RotationBase;
        /* 0x4C */ public float LineWidth;
        /* 0x50 */ public float LineWidthFade;
        /* 0x54 */ public float SizeScale;
        /* 0x58 */ public float RadiusMinimum;
        /* 0x5C */ public float RadiusBaseOffset;
        /* 0x60 */ public float RadiusEdge;
        /* 0x64 */ public Vector2f TimeScaleRange;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding6C;
    }
}
