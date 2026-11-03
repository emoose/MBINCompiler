using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x472B5270547B2C19, NameHash = 0xA3D1786E)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkModelResource ImpactEffect;
        [NMS(Index = 4)]
        /* 0x020 */ public TkModelResource ImpactExplode;
        [NMS(Index = 0)]
        /* 0x040 */ public TkModelResource IndicatorDecal;
        [NMS(Index = 2)]
        /* 0x060 */ public TkModelResource Meteor;
        [NMS(Index = 1)]
        /* 0x080 */ public TkModelResource StaticDecal;
        [NMS(Index = 18)]
        /* 0x0A0 */ public NMSString0x10 DamageID;
        [NMS(Index = 17)]
        /* 0x0B0 */ public NMSString0x10 ImpactParticle;
        [NMS(Index = 16)]
        /* 0x0C0 */ public NMSString0x10 ShakeID;
        [NMS(Index = 20)]
        /* 0x0D0 */ public float DamageRadius;
        [NMS(Index = 7)]
        /* 0x0D4 */ public float DecalFullGrowthProgress;
        [NMS(Index = 10)]
        /* 0x0D8 */ public float EarliestImpact;
        [NMS(Index = 11)]
        /* 0x0DC */ public float EarliestImpactFirstInstance;
        [NMS(Index = 9)]
        /* 0x0E0 */ public float FlashStartProgress;
        [NMS(Index = 19)]
        /* 0x0E4 */ public float FullDamageRadius;
        [NMS(Index = 15)]
        /* 0x0E8 */ public int MaxMeteors;
        [NMS(Index = 6)]
        /* 0x0EC */ public float MaxRadius;
        [NMS(Index = 14)]
        /* 0x0F0 */ public int MinMeteors;
        [NMS(Index = 5)]
        /* 0x0F4 */ public float MinRadius;
        [NMS(Index = 8)]
        /* 0x0F8 */ public float NumFlashes;
        [NMS(Index = 13)]
        /* 0x0FC */ public float Speed;
        [NMS(Index = 12)]
        /* 0x100 */ public float StormDuration;
    }
}
