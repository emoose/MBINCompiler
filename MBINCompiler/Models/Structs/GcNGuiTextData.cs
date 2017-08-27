namespace MBINCompiler.Models.Structs
{
    [NMS(Alignment = 0x10)]
    public class GcNGuiTextData : NMSTemplate       // size: 0x550
    {
        /* 0x000 */ public GcNGuiElementData Data;
        /* 0x050 */ public TkNGuiTextStyle Style;
        /* 0x110 */ public TkNGuiGraphicStyle GraphicStyle;

        [NMS(Size = 0x80)]
        /* 0x2C0 */ public string Image;

        [NMS(Size = 0x200)]
        /* 0x340 */ public string Text;

        /* 0x540 */ public bool Special;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] EndPadding;
    }
}
