namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D84D79C4F0EC061, NameHash = 0x7FD512F3)]
    public class GcCreatureHoverTintableEffect : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Colour TintColour;
        [NMS(Index = 1)]
        /* 0x10 */ public float LightStrength;
        [NMS(Index = 2)]
        /* 0x14 */ public float TintStrength;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x100 EffectNode;
    }
}
