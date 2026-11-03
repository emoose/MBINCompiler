namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x204BAD1A36E257B5, NameHash = 0x3E434CE8)]
    public class GcWeightedColourId : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 DecorationPaletteId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 PaletteId;
        [NMS(Index = 0, MxmlName = "Relative Probability")]
        /* 0x20 */ public float RelativeProbability;
    }
}
