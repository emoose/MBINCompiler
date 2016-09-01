using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x20)]
        public string Class;
        public int TransparencyLayerID;
        public bool CastShadow;
        public bool DisableZTest;
        [NMS(Size = 0x80)]
        public string Link;
        [NMS(Size = 0x80)]
        public string Shader;
        public List<TkMaterialFlags> Flags;
        public List<TkMaterialUniform> Uniforms;
        public List<TkMaterialSampler> Samplers;
    }
}
