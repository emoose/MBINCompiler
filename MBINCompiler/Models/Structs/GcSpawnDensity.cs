namespace MBINCompiler.Models.Structs
{
    public class GcSpawnDensity : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public bool Active;
        public int CoverageType;
        public string[] CoverageTypeValues()
        {
            return new[] { "Total", "SmoothPatch" };
        }

        public float PatchSize;
        public float RegionScale;
    }
}
