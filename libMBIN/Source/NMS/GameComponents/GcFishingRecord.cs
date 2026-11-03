namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4D69B0AA52386BC, NameHash = 0x4B8C0F87)]
    public class GcFishingRecord : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x100)]
        /* 0x0000 */ public NMSString0x10[] ProductList;
        [NMS(Index = 2, Size = 0x100)]
        /* 0x1000 */ public float[] LargestCatchList;
        [NMS(Index = 1, Size = 0x100)]
        /* 0x1400 */ public uint[] ProductCountList;
    }
}
