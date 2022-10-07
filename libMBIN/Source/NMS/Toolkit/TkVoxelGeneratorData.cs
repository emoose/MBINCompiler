using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE434B739E9AA8AEB, NameHash = 0x7A347325F1154095)]
    public class TkVoxelGeneratorData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed BaseSeed;
        /* 0x0010 */ public float SeaLevel;
        /* 0x0014 */ public float BeachHeight;
        /* 0x0018 */ public float NoSeaBaseLevel;
        /* 0x001C */ public TkNoiseVoxelTypeEnum BuildingVoxelType;
        /* 0x0020 */ public TkNoiseVoxelTypeEnum ResourceVoxelType;
        // size: 0x8
        public enum NoiseLayersEnum {
            Base,
            Hill,
            Mountain,
            Rock,
            UnderWater,
            Texture,
            Elevation,
            Continent
        }
        [NMS(Size = 0x8, EnumType = typeof(NoiseLayersEnum))]
        /* 0x0024 */ public TkNoiseUberLayerData[] NoiseLayers;
        // size: 0x9
        public enum GridLayersEnum {
            Small,
            Large,
            Resources_Heridium,
            Resources_Iridium,
            Resources_Copper,
            Resources_Nickel,
            Resources_Aluminium,
            Resources_Gold,
            Resources_Emeril
        }
        [NMS(Size = 0x9, EnumType = typeof(GridLayersEnum))]
        /* 0x0464 */ public TkNoiseGridData[] GridLayers;
        // size: 0x7
        public enum FeaturesEnum {
            River,
            Crater,
            Arches,
            ArchesSmall,
            Blobs,
            BlobsSmall,
            Substance
        }
        [NMS(Size = 0x7, EnumType = typeof(FeaturesEnum))]
        /* 0x134C */ public TkNoiseFeatureData[] Features;
        // size: 0x1
        public enum CavesEnum {
            Underground
        }
        [NMS(Size = 0x1, EnumType = typeof(CavesEnum))]
        /* 0x1528 */ public TkNoiseCaveData[] Caves;
        /* 0x15B0 */ public float MinimumCaveDepth;
        /* 0x15B4 */ public float CaveRoofSmoothingDist;
        /* 0x15B8 */ public float MaximumSeaLevelCaveDepth;
        /* 0x15BC */ public float BuildingTextureRadius;
        /* 0x15C0 */ public float BuildingSmoothingRadius;
        /* 0x15C4 */ public float BuildingSmoothingHeight;
        /* 0x15C8 */ public float WaterFadeInDistance;
    }
}
