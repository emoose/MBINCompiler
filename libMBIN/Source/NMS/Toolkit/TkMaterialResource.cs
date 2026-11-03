namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x285DB2A10592A86F, NameHash = 0x8A7C77D6)]
    public class TkMaterialResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcResource ResHandle;
    }
}
