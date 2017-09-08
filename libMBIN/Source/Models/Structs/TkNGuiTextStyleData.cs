namespace libMBIN.Models.Structs
{
    public class TkNGuiTextStyleData : NMSTemplate      // size: 0x40
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float FontHeight;
        /* 0x14 */ public float FontSpacing;
        /* 0x18 */ public bool IsIndented;
        /* 0x19 */ public bool HasDropShadow;
        /* 0x1C */ public float DropShadowOffset;
        /* 0x20 */ public bool HasOutline;

        /* 0x24 */ public float OutlineSize;
        /* 0x28 */ public bool IsParagraph;
        /* 0x29 */ public bool AllowScroll;
        /* 0x2A */ public bool ForceUpperCase;
        /* 0x2B */ public bool AutoAdjustHeight;
        /* 0x2C */ public int FontIndex;
        /* 0x30 */ public TkNGuiAlignment Align;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
