using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71CA8693422AD72A, NameHash = 0x9CD171737A52721E)]
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
        /* 0x38 */ public NMSString0x20 ShootLocatorName;
        /* 0x58 */ public NMSString0x10 MuzzleFlashEffect;
        /* 0x68 */ public GcAudioWwiseEvents StartFireAudioEvent;
        /* 0x6C */ public GcAudioWwiseEvents StopFireAudioEvent;
        /* 0x70 */ public NMSString0x10 ChargingIdleAnimId;
        /* 0x80 */ public float ChargeTime;
        /* 0x84 */ public float ChargeLightIntensity;
        /* 0x88 */ public NMSString0x10 ProjectileId;
        /* 0x98 */ public int NumProjectiles;
        /* 0x9C */ public float ProjectileSpread;
        /* 0xA0 */ public float FireInterval;
        /* 0xA4 */ public int NumShotsMin;
        /* 0xA8 */ public int NumShotsMax;
        /* 0xAC */ public float ExplosionRadius;
        /* 0xB0 */ public float InheritInitialVelocity;
        /* 0xB8 */ public NMSString0x10 LaunchProjectileAnimId;
    }
}
