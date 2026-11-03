using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C6D84EFF227485B, NameHash = 0xD942199B)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public Vector3f DiscoveryUIOffset;
        [NMS(Index = 17)]
        /* 0x10 */ public Vector3f PetLargeUIOverrideOffset;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 DeathEffect;
        [NMS(Index = 5)]
        /* 0x30 */ public NMSString0x10 DeathEffectTrail;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 14)]
        /* 0x50 */ public List<HashedString> PetAccessoryNodes;
        [NMS(Index = 8)]
        /* 0x60 */ public List<GcReplacementEffectData> ReplacementImpacts;
        [NMS(Index = 13)]
        /* 0x70 */ public List<GcCreatureDiscoveryThumbnailOverride> ThumbnailOverrides;
        [NMS(Index = 9)]
        /* 0x80 */ public float AccessoryPitchOffset;
        [NMS(Index = 1)]
        /* 0x84 */ public GcPrimaryAxis Axis;
        [NMS(Index = 6)]
        /* 0x88 */ public float DeathEffectScale;
        [NMS(Index = 7)]
        /* 0x8C */ public float DeathFadeTime;
        [NMS(Index = 10)]
        /* 0x90 */ public float DiscoveryFurScaler;
        [NMS(Index = 11)]
        /* 0x94 */ public float DiscoveryUIScaler;
        [NMS(Index = 26)]
        /* 0x98 */ public float NavRadiusModifier;
        [NMS(Index = 3)]
        /* 0x9C */ public float PetIndoorScaler;
        [NMS(Index = 16)]
        /* 0xA0 */ public float PetLargeUIOverrideScaler;
        [NMS(Index = 2)]
        /* 0xA4 */ public float Scaler;
        [NMS(Index = 24)]
        /* 0xA8 */ public float UnderwaterRagdollAnimStrength;
        [NMS(Index = 25)]
        /* 0xAC */ public float UnderwaterRagdollAnimTime;
        [NMS(Index = 20)]
        /* 0xB0 */ public float UnderwaterRagdollDamping;
        [NMS(Index = 21)]
        /* 0xB4 */ public float UnderwaterRagdollDampingTime;
        [NMS(Index = 19)]
        /* 0xB8 */ public float UnderwaterRagdollGravityScale;
        [NMS(Index = 22)]
        /* 0xBC */ public float UnderwaterRagdollSpinStrength;
        [NMS(Index = 23)]
        /* 0xC0 */ public float UnderwaterRagdollSpinTime;
        [NMS(Index = 15)]
        /* 0xC4 */ public bool UsePetLargeUIOverride;
        [NMS(Index = 18)]
        /* 0xC5 */ public bool UseStandardWaterPusher;
    }
}
