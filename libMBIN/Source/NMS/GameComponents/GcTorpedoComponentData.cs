namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA80E51B7009021F3, NameHash = 0xA5B9F71571A61869)]
    public class GcTorpedoComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageProjectileId;
        /* 0x10 */ public NMSString0x10 DamageShieldProjectileId;
        /* 0x20 */ public NMSString0x10 DestroyedEffect;
        /* 0x30 */ public float NoTargetLife;
        /* 0x34 */ public float MaxLifetime;
        /* 0x38 */ public float ApproachTime;
        /* 0x3C */ public float MinCircleTime;
        /* 0x40 */ public float RotateSpeed;
        /* 0x44 */ public float MaxSpeed;
        /* 0x48 */ public float ForceMin;
        /* 0x4C */ public float ForceMax;
        /* 0x50 */ public float BrakeTime;
        /* 0x54 */ public float BrakeForceMin;
        /* 0x58 */ public float BrakeForceMax;
        /* 0x5C */ public float HitRadius;
    }
}
