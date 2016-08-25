namespace MBINCompiler.Models.Structs
{
    public class GcNGuiGraphicData : NMSTemplate
    {
        public GcNGuiElementData ElementData;
        public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
