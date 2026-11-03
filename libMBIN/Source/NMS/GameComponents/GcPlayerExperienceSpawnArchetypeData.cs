using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94F24B2BADAF4DA7, NameHash = 0x93BDA22E)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 AppearAnim;
        [NMS(Index = 16)]
        /* 0x10 */ public List<NMSTemplate> BehaviourOverrides;
        [NMS(Index = 15)]
        /* 0x20 */ public NMSString0x10 BehaviourTreeOverride;
        [NMS(Index = 17)]
        /* 0x30 */ public List<NMSTemplate> BlackboardValues;
        [NMS(Index = 8)]
        /* 0x40 */ public NMSString0x10 DamageOverride;
        [NMS(Index = 9)]
        /* 0x50 */ public NMSString0x10 DamageReceivedMultiplier;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x10 GenerateResource;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Id;
        [NMS(Index = 14)]
        /* 0x80 */ public NMSString0x10 KillingBlowMessageIDOverride;
        [NMS(Index = 13)]
        /* 0x90 */ public NMSString0x10 KillStatIDOverride;
        [NMS(Index = 11)]
        /* 0xA0 */ public float DespawnDistOverride;
        [NMS(Index = 7)]
        /* 0xA4 */ public int HealthOverride;
        [NMS(Index = 3)]
        /* 0xA8 */ public float Scale;
        [NMS(Index = 4)]
        /* 0xAC */ public float ScaleVariation;
        [NMS(Index = 10)]
        /* 0xB0 */ public float SpawnDistOverride;
        [NMS(Index = 6)]
        /* 0xB4 */ public float SpeedMultiplier;
        [NMS(Index = 2)]
        /* 0xB8 */ public GcCreatureTypes Type;
        [NMS(Index = 12)]
        /* 0xBC */ public bool AllowSpawnInAir;
    }
}
