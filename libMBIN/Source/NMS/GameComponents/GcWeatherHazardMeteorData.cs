using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2F0, Alignment = 0x8, GUID = 0xC878C80DB7EAF5B1, NameHash = 0x89A5F03E5191DE14)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        /* 0x000 */ public TkModelResource IndicatorDecal;
        /* 0x084 */ public TkModelResource StaticDecal;
        /* 0x108 */ public TkModelResource Meteor;
        /* 0x18C */ public TkModelResource ImpactEffect;
        /* 0x210 */ public TkModelResource ImpactExplode;
        /* 0x294 */ public float MinRadius;
        /* 0x298 */ public float MaxRadius;
        /* 0x29C */ public float EarliestImpact;
        /* 0x2A0 */ public float EarliestImpactFirstInstance;
        /* 0x2A4 */ public float StormDuration;
        /* 0x2A8 */ public float Speed;
        /* 0x2AC */ public int MinMeteors;
        /* 0x2B0 */ public int MaxMeteors;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2B4 */ public byte[] Padding2B4;
        [NMS(Size = 0x10)]
        /* 0x2B8 */ public string ShakeID;
        [NMS(Size = 0x10)]
        /* 0x2C8 */ public string ImpactParticle;
        [NMS(Size = 0x10)]
        /* 0x2D8 */ public string DamageID;
        /* 0x2E8 */ public float FullDamageRadius;
        /* 0x2EC */ public float DamageRadius;
    }
}
