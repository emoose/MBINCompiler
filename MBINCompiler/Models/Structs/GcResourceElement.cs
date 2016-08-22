using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcResourceElement : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Filename;
        public long EmptyNode1;
        public GcSeed GenerationSeed;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string AltId;
        public TkProceduralTextureChosenOptionList Texture;
    }
}
