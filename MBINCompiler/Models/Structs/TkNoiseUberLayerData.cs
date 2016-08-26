namespace MBINCompiler.Models.Structs
{
    public class TkNoiseUberLayerData : NMSTemplate // 0x68 bytes
    {
        public TkNoiseUberData NoiseData;
        public bool Active;
        public int MaximumLOD;
        public bool Subtract;
        public TkNoiseVoxelTypeEnum NoiseVoxelType;
        public float Height;
        public float Width;
        public float RegionRatio;
        public float RegionScale;
        public float SmoothRadius;
        public float HeightOffset;
        public TkNoiseOffsetEnum OffsetType;
        public int WaterFade;
        public string[] WaterFadeValues()
        {
            return new[] { "None", "Above", "Below" };
        }
        public float PlateauStratas;
        public int PlateauSharpness;
        public float PlateauRegionSize;
        public int SeedOffset;
    }
}
