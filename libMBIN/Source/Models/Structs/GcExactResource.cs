namespace MBINCompiler.Models.Structs
{
    public class GcExactResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        public GcSeed GenerationSeed;
    }
}
