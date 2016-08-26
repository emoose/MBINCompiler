namespace MBINCompiler.Models.Structs
{
    public class TkVoxelGeneratorData : NMSTemplate
    {
        public GcSeed BaseSeed;
        public float SeaRatio;
        public float NoSeaBaseLevel;
        public TkNoiseVoxelTypeEnum NoiseVoxelType1;
        public TkNoiseVoxelTypeEnum NoiseVoxelType2;

        [NMS(Size = 7)]
        public TkNoiseUberLayerData[] NoiseLayers;
        [NMS(Size = 9)]
        public TkNoiseGridData[] GridLayers;
        [NMS(Size = 7)]
        public TkNoiseFeatureData[] Features;

        public TkNoiseCaveData CavesUnderground;
        public float MinimumCaveDepth;
        public float CaveRoofSmoothingDist;
        public float MaximumSeaLevelCaveDepth;
        public float BuildingTextureRadius;
        public float BuildingSmoothingRadius;
        public float BuildingSmoothingHeight;
        public float WaterFadeInDistance;

        [NMS(Size = 0x50)]
        public byte[] Regions;
        // todo: change Regions byte array above to the below once primitive arrays/lists are done
        // public TkVoxelGeneratorRegionData Regions;
    }
}
