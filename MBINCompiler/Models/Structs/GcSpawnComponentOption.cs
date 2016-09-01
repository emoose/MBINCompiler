namespace MBINCompiler.Models.Structs
{
    public class GcSpawnComponentOption : NMSTemplate // 0x2C8 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcSeed Seed;
        public GcResourceElement SpecificModel;
    }
}
