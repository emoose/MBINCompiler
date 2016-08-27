using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
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
}
