namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74E6DC1315C9968, NameHash = 0x5F253115B1050DE1)]
    public class GcOverlayTexture : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 OverlayDiffuse;
        /* 0x080 */ public NMSString0x80 OverlayNormal;
        /* 0x100 */ public NMSString0x80 OverlayMasks;
        /* 0x180 */ public int OverlayMaskIdx;
    }
}
