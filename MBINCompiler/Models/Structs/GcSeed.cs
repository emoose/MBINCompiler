namespace MBINCompiler.Models.Structs
{
    public class GcSeed : NMSTemplate
    {
        public long Seed;
        public bool UseSeedValue;
        [NMSAttribute(Ignore = true)]
        public int EmptyNode1;
    }
}
