using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x26767D77251409B9, NameHash = 0x31D184CC)]
    public class TkMeshWaterQualitySettingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkWaterMeshConfig WaterMeshConfig;
        [NMS(Index = 5)]
        /* 0x24 */ public bool EnableDetailNormals;
        [NMS(Index = 6)]
        /* 0x25 */ public bool EnableDynamicWaves;
        [NMS(Index = 1)]
        /* 0x26 */ public bool EnableFoam;
        [NMS(Index = 2)]
        /* 0x27 */ public bool EnableLocalTerrain;
        [NMS(Index = 3)]
        /* 0x28 */ public bool PostProcessWater;
        [NMS(Index = 4)]
        /* 0x29 */ public bool RainDropEffect;
    }
}
