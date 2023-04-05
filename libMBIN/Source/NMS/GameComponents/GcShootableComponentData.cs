using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CD0DB0FA7629924, NameHash = 0x387AC5FC8E642A15)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public int Health;
        /* 0x04 */ public bool AutoAimTarget;
        /* 0x05 */ public bool PlayerOnly;
        /* 0x06 */ public bool IgnorePlayer;
        /* 0x07 */ public bool ImpactShake;
        /* 0x08 */ public NMSString0x10 ImpactShakeEffect;
        /* 0x18 */ public GcProjectileImpactType ForceImpactType;
        /* 0x1C */ public int IncreaseWanted;
        /* 0x20 */ public int IncreaseCorruptSentinelWanted;
        /* 0x24 */ public float IncreaseWantedThresholdTime;
        /* 0x28 */ public GcFiendCrime FiendCrimeType;
        /* 0x2C */ public float FiendCrimeModifier;
        /* 0x30 */ public float RepairTime;
        /* 0x34 */ public int MinDamage;
        /* 0x38 */ public bool StaticUntilShot;
        /* 0x39 */ public bool IgnoreHitPush;
        /* 0x3A */ public bool HitEffectEnabled;
        /* 0x3B */ public bool HitEffectEntireModel;
        /* 0x3C */ public bool IsArmoured;
        /* 0x3D */ public bool CouldCountAsArmourForParent;
        /* 0x3E */ public bool IgnoreTerrainEditKills;
        /* 0x3F */ public NMSString0x20 NameOverride;
        /* 0x60 */ public NMSString0x10 RequiredTech;
        /* 0x70 */ public NMSString0x10 DamageMultiplier;
        /* 0x80 */ public bool IsPiercable;
        /* 0x81 */ public bool IsAffectedByPiercing;
    }
}
