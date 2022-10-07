namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E15DB90CA3FBF5B, NameHash = 0x2AD2911065D6EA2)]
    public class GcTerrainControls : NMSTemplate
    {
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
        /* 0x00 */ public float[] NoiseLayers;
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
        /* 0x20 */ public float[] GridLayers;
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
        /* 0x44 */ public float[] Features;
        // size: 0x1
        public enum CavesEnum {
            Underground
        }
        [NMS(Size = 0x1, EnumType = typeof(CavesEnum))]
        /* 0x60 */ public float[] Caves;
        /* 0x64 */ public float WaterActiveFrequency;
        /* 0x68 */ public float HighWaterActiveFrequency;
        /* 0x6C */ public float RockTileFrequency;
        /* 0x70 */ public float SubstanceTileFrequency;
        /* 0x74 */ public bool ForceContinentalNoise;
    }
}
