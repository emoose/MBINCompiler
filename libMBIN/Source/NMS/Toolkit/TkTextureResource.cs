namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5DAA76FCB2A9E351, NameHash = 0xEA5D5BE5)]
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcResource ResHandle;
    }
}
