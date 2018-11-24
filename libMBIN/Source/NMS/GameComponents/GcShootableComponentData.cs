using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, Alignment = 0x8, GUID = 0x14A50F19D60AD726)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public int Health;
		/* 0x04 */ public bool AutoAimTarget;
		/* 0x05 */ public bool PlayerOnly;
		/* 0x06 */ public bool ImpactShake;
		[NMS(Size = 1, Ignore = true)]
		/* 0x07 */ public byte[] Padding7;
		[NMS(Size = 0x10)]
		/* 0x08 */ public string ImpactShakeEffect;

		/* 0x18 */ public GcProjectileImpactType ForceImpactType;
		/* 0x1C */ public int IncreaseWanted;
		/* 0x20 */ public float IncreaseWantedThresholdTime;
        /* 0x24 */ public GcFiendCrime FiendCrimeType;
        /* 0x28 */ public float FiendCrimeModifier;
		/* 0x2C */ public float RepairTime;
		/* 0x30 */ public int MinDamage;
		/* 0x34 */ public bool StaticUntilShot;
        /* 0x35 */ public bool HitEffectEnabled;
        /* 0x36 */ public bool HitEffectEntireModel;
        /* 0x37 */ public bool IsArmoured;
        /* 0x38 */ public bool IgnoreTerrainEditKill;
        [NMS(Size = 0x20)]
        /* 0x39 */ public string NameOverride;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x59 */ public byte[] Padding59;

		[NMS(Size = 0x10)]
		/* 0x60 */ public string RequiredTech;
        [NMS(Size = 0x10)]
		/* 0x70 */ public string DamageMultiplier;

    }
}
