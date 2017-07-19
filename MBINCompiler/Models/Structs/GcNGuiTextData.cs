namespace MBINCompiler.Models.Structs
{
    public class GcNGuiTextData : NMSTemplate       // size: 0x560
    {
        /* 0x000 */ public GcNGuiElementData Data;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x058 */ public byte[] Padding58;
        /* 0x060 */ public TkNGuiTextStyle Style;
        /* 0x120 */ public TkNGuiGraphicStyle GraphicStyle;

        [NMS(Size = 0x80)]
        /* 0x2D0 */ public string Image;

        [NMS(Size = 0x200)]
        /* 0x350 */ public string Text;

        /* 0x550 */ public bool Special;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] EndPadding;
    }
}
