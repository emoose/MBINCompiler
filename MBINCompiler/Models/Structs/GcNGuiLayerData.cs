using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiLayerData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiGraphicStyle Style;
        public NMSString0x80 Image;
        public List<NMSTemplate> Children;
        public NMSString0x80 DataFilename;
    }
}
