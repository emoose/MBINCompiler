using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD63F0BBEBE41DA78, NameHash = 0x3B132872)]
    public class GcTerrainTexture : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename DiffuseTexture;
        [NMS(Index = 1)]
        /* 0x10 */ public GcFilename NormalMap;
        [NMS(Index = 2, Size = 0xC)]
        /* 0x20 */ public GcTerrainTextureSettings[] TextureConfig;
    }
}
