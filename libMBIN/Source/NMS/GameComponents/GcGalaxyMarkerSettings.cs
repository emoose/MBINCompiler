namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D337FA7A210A1B8, NameHash = 0xB24FD22ADB1D885D)]
    public class GcGalaxyMarkerSettings : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x000 */ public Colour[] Colours;
        /* 0x030 */ public Colour OutlineColour;
        /* 0x040 */ public float OutlineWidth;
        /* 0x044 */ public int EdgeCount;
        /* 0x048 */ public float RotationBase;
        /* 0x04C */ public float LineWidth;
        /* 0x050 */ public float LineWidthFade;
        /* 0x054 */ public float SizeScale;
        /* 0x058 */ public float RadiusFixed;
        /* 0x05C */ public float RadiusMinimum;
        /* 0x060 */ public float RadiusBaseOffset;
        /* 0x064 */ public float RadiusEdge;
        /* 0x068 */ public NMSString0x80 Icon;
        /* 0x0E8 */ public Vector2f IconSize;
        /* 0x0F0 */ public NMSString0x20 MarkerLabel;
        /* 0x110 */ public Vector2f TimeScaleRange;
    }
}
