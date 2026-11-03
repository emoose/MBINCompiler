namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20CE53D446382190, NameHash = 0x48EB1056)]
    public class GcWeightedFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public float Weight;
    }
}
