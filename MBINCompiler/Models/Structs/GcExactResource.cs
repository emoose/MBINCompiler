using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcExactResource : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Filename;
        public GcSeed GenerationSeed;
    }
}
