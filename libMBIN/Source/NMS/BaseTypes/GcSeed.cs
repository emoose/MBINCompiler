namespace libMBIN.NMS {

    [NMS(Size = 0x10)]
    public class GcSeed : NMSTemplate
    {
        /* 0x0 */ public long Seed;
        /* 0x8 */ public bool UseSeedValue;
        [NMS(Size = 7, Ignore = true)]
        /* 0x9 */ public byte[] EndPadding;
    }

}
