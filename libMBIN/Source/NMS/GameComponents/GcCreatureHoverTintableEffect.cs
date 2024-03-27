namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE224BE025A4ECB8, NameHash = 0xFE54641DFEAF51F)]
    public class GcCreatureHoverTintableEffect : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 EffectNode;
        /* 0x100 */ public float LightStrength;
        /* 0x104 */ public float TintStrength;
        /* 0x110 */ public Colour TintColour;
    }
}
