using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        public List<float> Sizes;

        [NMS(Size = 5)]
        public Colour[] SkinColours;

        public float SkinFontHeight;

        [NMS(Size = 0x80)]
        public string Font;

        public List<TkNGuiGraphicStyle> GraphicStyles;
        public List<TkNGuiTextStyle> TextStyles;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding108;
    }
}
