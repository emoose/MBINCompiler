namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x583143341C4145B1, NameHash = 0xDD504892)]
    public class GcExactResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSeed GenerationSeed;
    }
}
