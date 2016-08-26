namespace MBINCompiler.Models.Structs
{
    public class GcTerrainControls : NMSTemplate
    {
        [NMS(Size = 7)]
        public NMSFloat[] NoiseLayers;
        [NMS(Size = 9)]
        public NMSFloat[] GridLayers;
        [NMS(Size = 7)]
        public NMSFloat[] Features;

        public float UndergroundCaves;
        public float WaterActiveFrequency;
        public float HighWaterActiveFrequency;
        public float RockTileFrequency;
        public float SubstanceTileFrequency;
    }
}
