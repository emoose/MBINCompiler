namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5282F995742A4CD7, NameHash = 0xAFBCA5DD)]
    public class GcTextStyleShadow : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour ShadowColour;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector2f ShadowOffset;
    }
}
