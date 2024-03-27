using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC141908707421651, NameHash = 0x387AC5FC8E642A15)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public int Health;
        /* 0x04 */ public int LevelledExtraHealth;
        /* 0x08 */ public bool UseSpaceLevelForExtraHealth;
        /* 0x09 */ public bool AutoAimTarget;
        /* 0x0A */ public bool PlayerOnly;
        /* 0x0B */ public bool IgnorePlayer;
        /* 0x0C */ public bool ImpactShake;
        /* 0x10 */ public NMSString0x10 ImpactShakeEffect;
        /* 0x20 */ public GcProjectileImpactType ForceImpactType;
        /* 0x24 */ public int IncreaseWanted;
        /* 0x28 */ public int IncreaseCorruptSentinelWanted;
        /* 0x2C */ public float IncreaseWantedThresholdTime;
        /* 0x30 */ public GcFiendCrime FiendCrimeType;
        /* 0x34 */ public float FiendCrimeModifier;
        /* 0x38 */ public float RepairTime;
        /* 0x3C */ public int MinDamage;
        /* 0x40 */ public bool StaticUntilShot;
        /* 0x41 */ public bool IgnoreHitPush;
        /* 0x42 */ public bool HitEffectEnabled;
        /* 0x43 */ public bool HitEffectEntireModel;
        /* 0x44 */ public bool IsArmoured;
        /* 0x45 */ public bool CouldCountAsArmourForParent;
        /* 0x46 */ public bool IgnoreTerrainEditKills;
        /* 0x47 */ public NMSString0x20 NameOverride;
        /* 0x68 */ public NMSString0x10 RequiredTech;
        /* 0x78 */ public NMSString0x10 DamageMultiplier;
        /* 0x88 */ public bool IsPiercable;
        /* 0x89 */ public bool IsAffectedByPiercing;
    }
}
