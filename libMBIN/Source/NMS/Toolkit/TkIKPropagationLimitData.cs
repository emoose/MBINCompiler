using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBED09EBF7FC482F5, NameHash = 0x7CCB4C3B)]
    public class TkIKPropagationLimitData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x10 ConfigId;
        [NMS(Index = 5)]
        /* 0x010 */ public TkIKPropagationLimitMode BehaviourAtLimit;
        [NMS(Index = 2)]
        /* 0x014 */ public float BlendInTime;
        [NMS(Index = 3)]
        /* 0x018 */ public float BlendOutTime;
        [NMS(Index = 1)]
        /* 0x01C */ public NMSString0x100 LimitJointName;
        [NMS(Index = 4)]
        /* 0x11C */ public TkCurveType BlendCurve;
    }
}
