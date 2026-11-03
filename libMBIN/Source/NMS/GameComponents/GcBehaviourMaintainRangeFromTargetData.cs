using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC004BE67FF735A6, NameHash = 0xA5F9B634)]
    public class GcBehaviourMaintainRangeFromTargetData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkBlackboardDefaultValueFloat MaxDist;
        [NMS(Index = 1)]
        /* 0x18 */ public TkBlackboardDefaultValueFloat MinDist;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 TargetKey;
        [NMS(Index = 6)]
        /* 0x40 */ public float AvoidCreaturesStrength;
        [NMS(Index = 5)]
        /* 0x44 */ public float SpeedModifier;
        [NMS(Index = 3, MxmlName = "2D")]
        /* 0x48 */ public bool _2D;
        [NMS(Index = 4)]
        /* 0x49 */ public bool SucceedWhenInRange;
    }
}
