using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x2C, GUID = 0x3B502AF5CCB4C9F, NameHash = 0x6ECA0FF0AE9F9E21)]
    public class TkEmitterFloatProperty : NMSTemplate
    {
        public enum AuthoringEnum { FixedValue, RandomRangeFloat, Curves }
        /* 0x00 */ public AuthoringEnum Authoring;
        /* 0x04 */ public float FixedValue;
        /* 0x04 */ public float MinRandomValue;
        /* 0x04 */ public float MaxRandomValue;
        /* 0x04 */ public float CurveVariation;
        /* 0x04 */ public float CurveStartValue;
        /* 0x04 */ public float CurveMidValue;
        /* 0x04 */ public float CurveEndValue;
        /* 0x04 */ public float CurveBlendMidpoint;
        /* 0x04 */ public TkCurveType Curve1Shape;
        /* 0x04 */ public TkCurveType Curve2Shape;
    }
}
