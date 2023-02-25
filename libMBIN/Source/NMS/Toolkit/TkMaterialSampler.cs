namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB1F00BB1F804178A, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public NMSString0x80 Map;
        /* 0xA0 */ public bool IsCube;
        /* 0xA1 */ public bool UseCompression;
        /* 0xA2 */ public bool UseMipMaps;
        /* 0xA3 */ public bool IsSRGB;
        /* 0xA8 */ public NMSString0x20A MaterialAlternativeId;
        // size: 0x4
        public enum TextureAddressModeEnum : uint {
            Wrap,
            Clamp,
            ClampToBorder,
            Mirror,
        }
        /* 0xC8 */ public TextureAddressModeEnum TextureAddressMode;
        // size: 0x3
        public enum TextureFilterModeEnum : uint {
            None,
            Bilinear,
            Trilinear,
        }
        /* 0xCC */ public TextureFilterModeEnum TextureFilterMode;
        /* 0xD0 */ public int Anisotropy;
    }
}
