using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7FAC045AF95B3CFE, NameHash = 0x81D3809C)]
    public class TkLODModelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LODModel;
        [NMS(Index = 1)]
        /* 0x20 */ public float Distance;
        [NMS(Index = 2)]
        /* 0x24 */ public float SwapThreshold;
    }
}
