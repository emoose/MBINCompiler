using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiLayerData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        public string Image;
        public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        public string DataFilename;
    }
}
