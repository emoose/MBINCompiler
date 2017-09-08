using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Alignment = 0x10, Size = 0x310)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData Data;
        /* 0x050 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x200 */ public string Image;
        /* 0x280 */ public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        /* 0x290 */ public string DataFilename;
    }
}
