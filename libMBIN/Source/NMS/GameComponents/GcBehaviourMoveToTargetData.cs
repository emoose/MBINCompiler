using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AC6C089A7C471A5, NameHash = 0x6CCA924D787E12E)]
    public class GcBehaviourMoveToTargetData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TargetKey;
        /* 0x10 */ public TkBlackboardDefaultValueFloat ArriveDist;
        // size: 0x3
        public enum BehaviourMoveSpeedEnum {
            Normal,
            Fast,
            Dynamic
        }
        /* 0x30 */ public BehaviourMoveSpeedEnum BehaviourMoveSpeed;
        /* 0x34 */ public float DynamicMoveSlowdownDistMul;
        /* 0x38 */ public float SpeedModifier;
        /* 0x3C */ public float AvoidCreaturesStrength;
    }
}
