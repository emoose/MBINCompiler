using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialFlags : NMSTemplate
    {
        public int MaterialFlag;
        public string[] MaterialFlagValues()
        {
            return new[] { "_F01_DIFFUSEMAP", "_F02_SKINNED", "_F03_NORMALMAP", "_F04_", "_F05_", "_F06_", "_F07_UNLIT", "_F08_", "_F09_TRANSPARENT", "_F10_NORECEIVESHADOW", "_F11_ALPHACUTOUT", "_F12_BATCHED_BILLBOARD", "_F13_UVANIMATION", "_F14_UVSCROLL", "_F15_WIND", "_F16_DIFFUSE2MAP", "_F17_MULTIPLYDIFFUSE2MAP", "_F18_UVTILES", "_F19_BILLBOARD", "_F20_PARALLAXMAP", "_F21_VERTEXCOLOUR", "_F22_TRANSPARENT_SCALAR", "_F23_CAMERA_RELATIVE", "_F24_AOMAP", "_F25_ROUGHNESS_MASK", "_F26_STRETCHY_PARTICLE", "_F27_VBTANGENT", "_F28_VBSKINNED", "_F29_VBCOLOUR", "_F30_REFRACTION_MAP", "_F31_DISPLACEMENT", "_F32_LEAF", "_F33_GRASS", "_F34_GLOW", "_F35_GLOW_MASK", "_F36_DOUBLESIDED", "_F37_RECOLOUR", "_F38_NO_DEFORM", "_F39_METALLIC_MASK", "_F40_SUBSURFACE_MASK", "_F41_DETAIL_DIFFUSE", "_F42_DETAIL_NORMAL", "_F43_NORMAL_TILING", "_F44_IMPOSTER", "_F45_SCANABLE", "_F46_BILLBOARD_AT", "_F47_WRITE_LOG_Z", "_F48_WARPED_DIFFUSE_LIGHTING", "_F49_DISABLE_AMBIENT", "_F50_DISABLE_POSTPROCESS", "_F51_DECAL_DIFFUSE", "_F52_DECAL_NORMAL", "_F53_", "_F54_", "_F55_", "_F56_", "_F57_", "_F58_", "_F59_", "_F60_", "_F61_", "_F62_", "_F63_", "_F64_" };
        }
    }

    public class TkMaterialUniform : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Name;
        public Vector4f Values;
        public List<Vector4f> ExtendedValues;
    }

    public class TkMaterialSampler : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Map;
        public bool IsCube;
        public bool UseCompression;
        public bool UseMipMaps;
        public bool IsSRGB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] PaddingA4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string MaterialAlternativeId;
        public int TextureAddressMode;
        public string[] TextureAddressModeValues()
        {
            return new[] { "Wrap", "Clamp", "ClampToBorder", "Mirror" };
        }

        public int TextureFilterMode;
        public string[] TextureFilterModeValues()
        {
            return new[] { "None", "Bilinear", "Trilinear" };
        }

        public int Anisotropy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] PaddingC4;
    }

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
