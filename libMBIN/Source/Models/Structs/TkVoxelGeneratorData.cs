namespace libMBIN.Models.Structs
{
    public class TkVoxelGeneratorData : NMSTemplate // size: 0x12F8
    {
        /* 0x0000 */ public GcSeed BaseSeed;
        /* 0x0010 */ public float SeaRatio;
        /* 0x0014 */ public float NoSeaBaseLevel;
        /* 0x0018 */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        /* 0x001C */ public TkNoiseVoxelTypeEnum ResourceVoxelType;

        [NMS(Size = 7, EnumValue = new[] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation" })]
        /* 0x0020 */ public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 9, EnumValue = new[] { "Small", "Large", "Resources_Heridium", "Resources_Iridium", "Resources_Copper", "Resources_Nickel", "Resources_Aluminium", "Resources_Gold", "Resources_Emeril" })]
        /* 0x02F8 */ public TkNoiseGridData[] GridLayers;
        [NMS(Size = 7, EnumValue = new[] { "River", "Crater", "Arches", "ArchesSmall", "Blobs", "BlobsSmall", "Substance" })]
        /* 0x109C */ public TkNoiseFeatureData[] Features;
        [NMS(Size = 1, EnumValue = new[] { "Underground" })]
        /* 0x125C */ public TkNoiseCaveData[] CavesUnderground;
        /* 0x12DC */ public float MinimumCaveDepth;
        /* 0x12E0 */ public float CaveRoofSmoothingDist;
        /* 0x12E4 */ public float MaximumSeaLevelCaveDepth;
        /* 0x12E8 */ public float BuildingTextureRadius;
        /* 0x12EC */ public float BuildingSmoothingRadius;
        /* 0x12F0 */ public float BuildingSmoothingHeight;
        /* 0x12F4 */ public float WaterFadeInDistance;
    }
}
