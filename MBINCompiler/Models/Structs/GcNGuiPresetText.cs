namespace MBINCompiler.Models.Structs
{
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PresetID;
        public GcNGuiLayoutData Layout;
        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Size = 0x80)]
        public string Image;
    }
}
