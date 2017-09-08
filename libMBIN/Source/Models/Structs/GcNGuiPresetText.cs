namespace libMBIN.Models.Structs
{
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PresetID;
        public GcNGuiLayoutData Layout;
        [NMS(Size = 0x4)]
        public byte[] Padding3C;

        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Size = 0x80)]
        public string Image;
    }
}
