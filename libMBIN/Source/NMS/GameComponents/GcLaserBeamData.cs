using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64CF78479D25D87B, NameHash = 0x1AA966F8BA4E3153)]
    public class GcLaserBeamData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x80 BeamFile;
        /* 0x090 */ public NMSString0x80 BeamCoreFile;
        /* 0x110 */ public NMSString0x80 BeamTipFile;
        /* 0x190 */ public float Width;
        /* 0x194 */ public float HitWidth;
        /* 0x198 */ public float PulseFrequency;
        /* 0x19C */ public float PulseAmplitude;
        /* 0x1A0 */ public float StartTime;
        /* 0x1A4 */ public float EndTime;
        /* 0x1A8 */ public GcAudioWwiseEvents AudioStart;
        /* 0x1AC */ public GcAudioWwiseEvents AudioStop;
        /* 0x1B0 */ public GcAudioWwiseEvents AudioOverheat;
        /* 0x1B4 */ public int DefaultDamage;
        /* 0x1B8 */ public float ExtraPlayerDamage;
        /* 0x1BC */ public GcDamageType DamageType;
        /* 0x1C0 */ public float CriticalHitModifier;
        /* 0x1C8 */ public NMSString0x10 PlayerDamage;
        /* 0x1D8 */ public NMSString0x10 ImpactEffect;
        /* 0x1E8 */ public List<GcProjectileImpactData> Impacts;
        /* 0x1F8 */ public float HitRate;
        /* 0x1FC */ public bool SingleHit;
        /* 0x200 */ public float RagdollPush;
        /* 0x204 */ public float PhysicsPush;
        /* 0x208 */ public float MiningHitRate;
        /* 0x20C */ public bool HasLight;
        /* 0x20D */ public bool CanMine;
        /* 0x20E */ public bool ApplyCombatLevelMultipliers;
        /* 0x210 */ public float DroneImpulse;
        /* 0x214 */ public float PiercingDamagePercentage;
        /* 0x218 */ public float LightIntensity;
        /* 0x220 */ public Colour LightColour;
        /* 0x230 */ public Colour Colour;
        /* 0x240 */ public Vector3f ImpactOffset;
        /* 0x250 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        /* 0x260 */ public List<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers;
        /* 0x270 */ public float Speed;
    }
}
