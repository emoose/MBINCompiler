using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x22A52D3E97156EEF, NameHash = 0x91FBF976CBE15B5F)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public Colour ShadowColour;
        /* 0x20 */ public Colour OutlineColour;
        /* 0x30 */ public float FontHeight;
        /* 0x34 */ public float FontSpacing;
        /* 0x38 */ public float DropShadowAngle;
        /* 0x3C */ public float DropShadowOffset;
        /* 0x40 */ public float OutlineSize;
        /* 0x44 */ public int FontIndex;
        /* 0x48 */ public TkNGuiAlignment Align;
        /* 0x4A */ public bool IsIndented;
        /* 0x4B */ public bool HasDropShadow;
        /* 0x4C */ public bool HasOutline;
        /* 0x4D */ public bool IsParagraph;
        /* 0x4E */ public bool AllowScroll;
        /* 0x4F */ public bool ForceUpperCase;
        /* 0x50 */ public bool AutoAdjustHeight;
        /* 0x51 */ public bool AutoAdjustFontHeight;
        /* 0x52 */ public bool BlockAudio;
    }
}
