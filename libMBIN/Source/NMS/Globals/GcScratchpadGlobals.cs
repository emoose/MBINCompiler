using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x40, GUID = 0xC14472951E47BFF8)]
    public class GcScratchpadGlobals : NMSTemplate
    {
        /* 0x00 */ public List<GcPresetTextureData> IBLMaps;
        /* 0x10 */ public List<GcPresetTextureData> TerrainTextures;
        /* 0x20 */ public List<GcPresetTextureData> OverlayTextures;
        /* 0x30 */ public List<Colour> TerrainColours;
    }
}
