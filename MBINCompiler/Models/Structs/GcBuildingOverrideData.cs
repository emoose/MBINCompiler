namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcBuildingOverrideData : NMSTemplate
    {
        public GcSeed Seed;
        public Vector4f Position;
        public int Index;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}
