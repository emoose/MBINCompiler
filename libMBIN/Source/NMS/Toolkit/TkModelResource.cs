namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9DF29D040CF980B6, NameHash = 0x2232E698)]
    public class TkModelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 2)]
        /* 0x10 */ public ulong Seed;
        [NMS(Index = 1)]
        /* 0x18 */ public GcResource ResHandle;
    }
}
