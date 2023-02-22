namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCF5018310EDBC8A2, NameHash = 0x678F6A0ACE397B4)]
    public class TkFoliageData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Material;
        /* 0x80 */ public float Scale;
        /* 0x84 */ public float Density;
        /* 0x88 */ public float DensityVariance;
        /* 0x8C */ public float AngleMultiplier;
        /* 0x90 */ public bool AngleExponentially;
        /* 0xA0 */ public Colour Colour;
    }
}
