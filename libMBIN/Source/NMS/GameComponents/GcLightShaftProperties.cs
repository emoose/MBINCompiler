namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF80054E2AA7C77FE, NameHash = 0x95E6C4BF9139916C)]
    public class GcLightShaftProperties : NMSTemplate
    {
        /* 0x00 */ public float LightShaftScattering;
        /* 0x04 */ public float LightShaftStrength;
        /* 0x08 */ public float LightShaftBottom;
        /* 0x0C */ public float LightShaftTop;
        /* 0x10 */ public Colour LightShaftColourBottom;
        /* 0x20 */ public Colour LightShaftColourTop;
    }
}
