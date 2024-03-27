using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD031597BFE04C560, NameHash = 0x75816D38B6B42FE4)]
    public class TkProceduralTexture : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public TkPaletteTexture Palette;
        /* 0x028 */ public float Probability;
        // size: 0x3
        public enum TextureGameplayUseEnum : uint {
            IgnoreName,
            MatchName,
            DoNotMatchName,
        }
        /* 0x02C */ public TextureGameplayUseEnum TextureGameplayUse;
        /* 0x030 */ public bool OverrideAverageColour;
        /* 0x040 */ public Colour AverageColour;
        /* 0x050 */ public NMSString0x80 Diffuse;
        /* 0x0D0 */ public NMSString0x80 Normal;
        /* 0x150 */ public NMSString0x80 Mask;
    }
}
