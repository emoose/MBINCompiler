using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, Alignment = 0x8, GUID = 0xF881A2909310842F)]
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
        [NMS(Size = 0x20)]
        /* 0x37 */ public string NameOverride;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x57 */ public byte[] Padding57;

		[NMS(Size = 0x10)]
		/* 0x58 */ public string RequiredTech;
        [NMS(Size = 0x10)]
		/* 0x68 */ public string DamageMultiplier;

    }
}
