using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x120, GUID = 0x50BEBA95B0A13913)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        /* 0x000 */ public List<float> Sizes;

        [NMS(Size = 5)]
        /* 0x010 */ public Colour[] SkinColours;

        /* 0x060 */ public float SkinFontHeight;

        [NMS(Size = 0x80)]
        /* 0x064 */ public string Font;

        /* 0x0E8 */ public List<TkNGuiGraphicStyle> GraphicStyles;
        /* 0x0F8 */ public List<TkNGuiTextStyle> TextStyles;
        /* 0x108 */ public List<float> SnapSettings;

        [NMS(Size = 8, Ignore = true)]
        public byte[] EndPadding;
    }
}
