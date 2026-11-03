namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68BFC80F20B3C1AA, NameHash = 0xD8286D09)]
    public class GcHeavyAirColourData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour1;
        [NMS(Index = 1)]
        /* 0x10 */ public Colour Colour2;
        [NMS(Index = 2)]
        /* 0x20 */ public Colour ExtremeColour1;
        [NMS(Index = 3)]
        /* 0x30 */ public Colour ExtremeColour2;
    }
}
