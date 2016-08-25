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
}
