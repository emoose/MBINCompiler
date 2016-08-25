namespace MBINCompiler.Models.Structs
{
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PresetID;
        public GcNGuiLayoutData Layout;
        public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        public string Image;
    }

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

    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Font;

        [NMS(Size = 0xA)]
        public GcNGuiPresetGraphic[] Layer;

        [NMS(Size = 0xA)]
        public GcNGuiPresetGraphic[] Graphic;

        [NMS(Size = 0xA)]
        public GcNGuiPresetText[] Text;

        public GcNGuiLayoutData SpacingLayout;
    }
}
