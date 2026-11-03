using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD28CBF7D0B2C76D3, NameHash = 0x52090B8B)]
    public class TkHitCurveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkInOutCurve Curve;
        [NMS(Index = 0)]
        /* 0x8 */ public float Time;
    }
}
