using System.Collections.Generic;

namespace MBINCompiler.Models.Structs       // size: 0x320
{
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData Data;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x058 */ public byte[] Padding59;
        /* 0x060 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x210 */ public string Image;
        /* 0x290 */ public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        /* 0x2A0 */ public string DataFilename;
    }
}
