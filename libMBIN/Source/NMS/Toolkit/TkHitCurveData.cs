using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4EB2A8BE264CCDC8, NameHash = 0xA954F03559C40EB5)]
    public class TkHitCurveData : NMSTemplate
    {
        /* 0x0 */ public float Time;
        /* 0x4 */ public TkInOutCurve Curve;
    }
}
