namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE09A0309AEFD695B, NameHash = 0x75A01ACB)]
    public class GcHUDMarkerData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcFilename Distance;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFilename Icon;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename IconBehind;
    }
}
