namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4F7F52AFFB4383, NameHash = 0x9CD171737A52721E)]
    public class GcSentinelQuadWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float FireTimeMin;
        /* 0x14 */ public float FireTimeMax;
        /* 0x18 */ public float MinRange;
        /* 0x1C */ public float MaxRange;
        /* 0x20 */ public float MaxAttackAngle;
        /* 0x24 */ public float Timeout;
        /* 0x28 */ public NMSString0x10 FiringIdleAnimId;
        /* 0x38 */ public NMSString0x10 ChargingIdleAnimId;
        /* 0x48 */ public float ChargeTime;
        /* 0x4C */ public float ChargeLightIntensity;
        /* 0x50 */ public NMSString0x10 ProjectileId;
        /* 0x60 */ public int NumProjectiles;
        /* 0x64 */ public float ProjectileSpread;
        /* 0x68 */ public float FireInterval;
        /* 0x6C */ public int NumShotsMin;
        /* 0x70 */ public int NumShotsMax;
        /* 0x74 */ public float ExplosionRadius;
        /* 0x78 */ public float InheritInitialVelocity;
        /* 0x80 */ public NMSString0x10 LaunchProjectileAnimId;
    }
}
