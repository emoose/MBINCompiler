using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1E17BECA4DE7169E, NameHash = 0xC626640FD5AAB001)]
    public class TkLODModelResource : NMSTemplate
    {
        /* 0x00 */ public TkModelResource LODModel;
        /* 0x84 */ public float Distance;
        /* 0x88 */ public float SwapThreshold;
    }
}
