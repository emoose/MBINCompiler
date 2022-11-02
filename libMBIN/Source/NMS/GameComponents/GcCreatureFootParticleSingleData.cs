namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C2C9529702F3519, NameHash = 0x8CD0B53079BD773C)]
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 EffectName;
        /* 0x10 */ public float Scale;
        /* 0x14 */ public float MinCreatureSize;
        /* 0x18 */ public float MaxCreatureSize;
        // size: 0x3
        public enum MoveSpeedEnum {
            Always,
            Walk,
            Run
        }
        /* 0x1C */ public MoveSpeedEnum MoveSpeed;
    }
}
