namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFE10D844E5E5272, NameHash = 0x99208CD6)]
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Corner;
        [NMS(Index = 3)]
        /* 0x10 */ public GcFilename GlowCorner;
        [NMS(Index = 4)]
        /* 0x20 */ public GcFilename GlowLineHorizontal;
        [NMS(Index = 5)]
        /* 0x30 */ public GcFilename GlowLineVertical;
        [NMS(Index = 1)]
        /* 0x40 */ public GcFilename LineHorizontal;
        [NMS(Index = 2)]
        /* 0x50 */ public GcFilename LineVertical;
    }
}
