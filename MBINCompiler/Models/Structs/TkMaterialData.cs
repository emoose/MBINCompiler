using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Class;
        public int TransparencyLayerID;
        public bool CastShadow;
        public bool DisableZTest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Link;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Shader;
        public List<TkMaterialFlags> Flags;
        public List<TkMaterialUniform> Uniforms;
        public List<TkMaterialSampler> Samplers;
    }
}
