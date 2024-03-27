using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8959480696CF2F28, NameHash = 0x7C8B3A3A3EEFC49F)]
    public class GcBehaviourMaintainRangeFromTargetData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TargetKey;
        /* 0x10 */ public TkBlackboardDefaultValueFloat MinDist;
        /* 0x30 */ public TkBlackboardDefaultValueFloat MaxDist;
        /* 0x50 */ public bool _2D;
        /* 0x51 */ public bool SucceedWhenInRange;
        /* 0x54 */ public float SpeedModifier;
        /* 0x58 */ public float AvoidCreaturesStrength;
    }
}
