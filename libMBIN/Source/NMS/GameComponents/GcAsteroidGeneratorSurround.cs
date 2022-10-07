using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1652C79D9419F1F, NameHash = 0xCBF9C66D539633AF)]
    public class GcAsteroidGeneratorSurround : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGeneratorAssignment Assignment;
        /* 0x48 */ public float LowerRadius;
        /* 0x4C */ public float UpperRadius;
        /* 0x50 */ public float NoiseOffset;
        /* 0x54 */ public float NoiseScale;
        /* 0x58 */ public float NoiseApply;
    }
}
