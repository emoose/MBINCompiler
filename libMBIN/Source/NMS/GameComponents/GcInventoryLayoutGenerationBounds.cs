namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB60D30DE6DFB3569, NameHash = 0xDCCAA3DA4C5BEA87)]
    public class GcInventoryLayoutGenerationBounds : NMSTemplate
    {
        /* 0x00 */ public int MaxWidthSmall;
        /* 0x04 */ public int MaxHeightSmall;
        /* 0x08 */ public int MaxWidthStandard;
        /* 0x0C */ public int MaxHeightStandard;
        /* 0x10 */ public int MaxWidthLarge;
        /* 0x14 */ public int MaxHeightLarge;
    }
}