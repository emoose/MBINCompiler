namespace MBINCompiler.Models.Structs
{
    public class TkNoiseGridData : NMSTemplate // 0x184 bytes
    {
        public bool Active;
        public int MaximumLOD;
        public bool Subtract;
        public bool SwapZY;
        public bool Hemisphere;
        public TkNoiseVoxelTypeEnum NoiseVoxelType;
        public int NoiseGridType;
        public string[] NoiseGridTypeValues()
        {
            return new[]
            {
                "Cube", "Cone", "Torus", "Sphere", "Cylinder", "Capsule", "Corridor", "Pipe",
                "Puck", "SuperPrimitiveRandom", "SuperFormula_01", "SuperFormula_02", "SuperFormula_03", "SuperFormula_04", "SuperFormula_05", "SuperFormula_06",
                "SuperFormula_07", "SuperFormula_08", "SuperFormulaRandom", "SuperFormula", "SuperPrimitive", "File"
            };
        }

        [NMS(Size = 0x80)]
        public string Filename;
        public float MinWidth;
        public float MaxWidth;
        public float MinHeight;
        public float MaxHeight;
        public float MinHeightOffset;
        public float MaxHeightOffset;
        public float HeightOffset;

        public TkNoiseOffsetEnum OffsetType;
        public float RegionRatio;
        public float RegionScale;
        public TkNoiseUberLayerData TurbulenceNoiseLayer;
        public float Yaw;
        public float Pitch;
        public float Roll;
        public float VaryYaw;
        public float VaryPitch;
        public float VaryRoll;
        public float SmoothRadius;
        public int SeedOffset;
        public float RandomPrimitive;
        public TkNoiseSuperFormulaData SuperFormula1; // not an array
        public TkNoiseSuperFormulaData SuperFormula2; // not an array
        public TkNoiseSuperFormulaData SuperFormula3; // not an array

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding178; // ???
    }
}
