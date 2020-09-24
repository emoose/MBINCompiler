using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x210, GUID = 0x8D2FC9E068F622E6, NameHash = 0x417FE136A80C6A0A)]
    public class GcTerrainTexture : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DiffuseTexture;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string NormalMap;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string OverlayTexture;
        [NMS(Size = 0xC)]
        /* 0x180 */ public GcTerrainTextureSettings[] TextureConfig;
    }
}
