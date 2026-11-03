namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F05804B547CAB2D, NameHash = 0x6AF2B1D8)]
    public class GcOverlayTexture : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename OverlayDiffuse;
        [NMS(Index = 2)]
        /* 0x10 */ public GcFilename OverlayMasks;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename OverlayNormal;
        [NMS(Index = 3)]
        /* 0x30 */ public int OverlayMaskIdx;
    }
}
