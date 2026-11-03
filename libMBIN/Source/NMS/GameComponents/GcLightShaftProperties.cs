namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EC4795F0149D341, NameHash = 0xC94A23E0)]
    public class GcLightShaftProperties : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour LightShaftColourBottom;
        [NMS(Index = 5)]
        /* 0x10 */ public Colour LightShaftColourTop;
        [NMS(Index = 2, MxmlName = "LightShaft Bottom")]
        /* 0x20 */ public float LightShaftBottom;
        [NMS(Index = 0, MxmlName = "LightShaft Scattering")]
        /* 0x24 */ public float LightShaftScattering;
        [NMS(Index = 1, MxmlName = "LightShaft Strength")]
        /* 0x28 */ public float LightShaftStrength;
        [NMS(Index = 3, MxmlName = "LightShaft Top")]
        /* 0x2C */ public float LightShaftTop;
    }
}
