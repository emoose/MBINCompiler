using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x9F90, GUID = 0x97BBEC400DB04410, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Size = 0x2B, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0x0000 */ public float[] Sizes;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00AC */ public byte[] PaddingAC;
        [NMS(Size = 8)]
        /* 0x00B0 */ public TkNGuiEditorStyleColour[] SkinColours;
        /* 0x0530 */ public float SkinFontHeight;
        [NMS(Size = 0x80)]
        /* 0x0534 */ public string Font;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x05B4 */ public byte[] Padding5B4;
        [NMS(Size = 0x42, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x05C0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Size = 0xC, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9200 */ public TkNGuiTextStyle[] TextStyles;
        /* 0x9F80 */ public List<float> SnapSettings;
    }
}
