namespace libMBIN.NMS {

    [NMS(Size = 0x10, Alignment = 0x8)]
    public class GcSeed : NMSTemplate
    {
        /* 0x0 */ public long Seed;
        /* 0x8 */ public bool UseSeedValue;
    }

}
