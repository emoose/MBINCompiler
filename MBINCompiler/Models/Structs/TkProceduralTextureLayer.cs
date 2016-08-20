using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkProceduralTextureLayer : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;

        public float Probability;
        public int Unknown14;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Group;

        public bool SelectToMatchBase;
        public List<TkProceduralTexture> Textures;
    }
}
