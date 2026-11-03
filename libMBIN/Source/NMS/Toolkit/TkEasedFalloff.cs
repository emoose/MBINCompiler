using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6FB1D46AFB91F578, NameHash = 0xEA76999E)]
    public class TkEasedFalloff : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float Max;
        [NMS(Index = 0)]
        /* 0x04 */ public float Min;
        [NMS(Index = 2)]
        /* 0x08 */ public float NormalisedLeftMargin;
        [NMS(Index = 3)]
        /* 0x0C */ public float NormalisedRightMargin;
        [NMS(Index = 4)]
        /* 0x10 */ public TkCurveType LeftCurve;
        [NMS(Index = 5)]
        /* 0x11 */ public TkCurveType RightCurve;
    }
}
