using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x25E024F7E9E3C213, NameHash = 0xA394D25E5A975DA5)]
    public class TkAnimBlendNode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NodeId;
        /* 0x10 */ public NMSString0x40 WeightIn;
        /* 0x50 */ public float WeightRangeBegin;
        /* 0x54 */ public float WeightRangeEnd;
        /* 0x58 */ public float WeightSpringTime;
        /* 0x5C */ public TkCurveType WeightCurve;
        /* 0x60 */ public float InitialWeight;
        /* 0x68 */ public NMSTemplate BlendLeft;
        /* 0xB8 */ public NMSTemplate BlendRight;
    }
}
