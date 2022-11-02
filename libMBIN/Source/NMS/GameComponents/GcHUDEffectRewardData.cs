using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D248F140A535F94, NameHash = 0x4453C3D28B780FD8)]
    public class GcHUDEffectRewardData : NMSTemplate
    {
        /* 0x00 */ public int NumBoxes;
        /* 0x04 */ public float BoxAnimTime;
        /* 0x08 */ public float BoxRotate;
        /* 0x0C */ public float BoxAnimTimeBetweenBoxes;
        /* 0x10 */ public TkCurveType BoxAnimTimeCurve;
        /* 0x14 */ public Vector2f BoxSizeStart;
        /* 0x1C */ public float BoxThicknessStart;
        /* 0x20 */ public Colour BoxColourStart;
        /* 0x30 */ public Vector2f BoxSizeEnd;
        /* 0x40 */ public Colour BoxColourEnd;
        /* 0x50 */ public float BoxThicknessEnd;
    }
}
