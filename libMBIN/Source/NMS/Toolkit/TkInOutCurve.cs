using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x323106FDDDE6667, NameHash = 0x37F732EF5C0B44F6)]
    public class TkInOutCurve : NMSTemplate
    {
        /* 0x0 */ public float Midpoint;
        /* 0x4 */ public TkCurveType InCurve;
        /* 0x5 */ public TkCurveType OutCurve;
    }
}
