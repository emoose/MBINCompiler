namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x140033E688FC98AA, NameHash = 0xDB8D6EE6)]
    public class TkWaterMeshConfig : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float BaseScale;
        [NMS(Index = 5)]
        /* 0x04 */ public int DynamicWaveScale;
        [NMS(Index = 4)]
        /* 0x08 */ public int FoamScale;
        [NMS(Index = 1)]
        /* 0x0C */ public int GeometryDownSampleFactor;
        [NMS(Index = 2)]
        /* 0x10 */ public int LodCount;
        [NMS(Index = 3)]
        /* 0x14 */ public int LodDataResolution;
        [NMS(Index = 7)]
        /* 0x18 */ public int MaxHorizontalScaleMultiplier;
        [NMS(Index = 8)]
        /* 0x1C */ public int MinHorizontalScaleMultiplier;
        [NMS(Index = 6)]
        /* 0x20 */ public bool DisableSkirtGeneration;
    }
}
