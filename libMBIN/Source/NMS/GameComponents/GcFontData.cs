namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE2EB3339FBF0F49, NameHash = 0xE98A05A5)]
    public class GcFontData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename File;
        [NMS(Index = 1)]
        /* 0x10 */ public int MinCharWidth;
    }
}
