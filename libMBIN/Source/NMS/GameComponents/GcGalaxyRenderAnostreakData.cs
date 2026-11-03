namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19E6C61D8AA6DBE0, NameHash = 0x2F4BB516)]
    public class GcGalaxyRenderAnostreakData : NMSTemplate
    {
        [NMS(Index = 1, MxmlName = "Inner Colour")]
        /* 0x00 */ public Colour InnerColour;
        [NMS(Index = 0, MxmlName = "Outer Colour")]
        /* 0x10 */ public Colour OuterColour;
        [NMS(Index = 4)]
        /* 0x20 */ public float Contrast;
        [NMS(Index = 3, MxmlName = "Horizontal Scale")]
        /* 0x24 */ public float HorizontalScale;
        [NMS(Index = 2, MxmlName = "Vertical Compression")]
        /* 0x28 */ public float VerticalCompression;
    }
}
