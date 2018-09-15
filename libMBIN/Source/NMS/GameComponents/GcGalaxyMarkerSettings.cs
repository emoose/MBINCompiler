using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0xC107557450982F7E)]
    public class GcGalaxyMarkerSettings : NMSTemplate
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
        [NMS(Size = 0x80)]
        /* 0x64 */ public string Icon;
        /* 0xE4 */ public Vector2f IconSize;
        [NMS(Size = 0x20)]
        /* 0xEC */ public string MarkerLabel;
        /* 0x10C */ public Vector2f TimeScaleRange;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x114 */ public byte[] EndPadding;
    }
}
