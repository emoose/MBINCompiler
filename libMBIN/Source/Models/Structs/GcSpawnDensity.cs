namespace MBINCompiler.Models.Structs
{
    public class GcSpawnDensity : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;
        /* 0x010 */ public bool Active;
		[NMS(Size = 3, Ignore = true)]
        /* 0x011 */ public byte[] Padding011;
        /* 0x014 */ public int CoverageType;
        public string[] CoverageTypeValues()
        {
            return new[] { "Total", "SmoothPatch", "GridPatch" };
        }

        /* 0x018 */ public float PatchSize;
        /* 0x01C */ public float RegionScale;
    }
}
