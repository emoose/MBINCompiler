using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D55D8E2E6F5C9D7, NameHash = 0x419E50F8E497D496)]
    public class GcWeatherEffect : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x20A OSDMessage;
        /* 0x030 */ public List<GcWeightedFilename> Effects;
        // size: 0x5
        public enum SpawnConditionsEnum : uint {
            Anytime,
            DuringStorm,
            AtNight,
            NotInStorm,
            AtNightNotInStorm,
        }
        /* 0x040 */ public SpawnConditionsEnum SpawnConditions;
        /* 0x044 */ public int MaxHazardsOfThisTypeActive;
        /* 0x048 */ public NMSString0x10 ForcedOnByHazard;
        /* 0x058 */ public NMSString0x10 BlockedByCluster;
        // size: 0x3
        public enum WeatherEffectBehaviourEnum : uint {
            Static,
            Wander,
            ChasePlayer,
        }
        /* 0x068 */ public WeatherEffectBehaviourEnum WeatherEffectBehaviour;
        // size: 0x3
        public enum WeatherEffectSpawnTypeEnum : uint {
            Single,
            Cluster,
            Patch,
        }
        /* 0x06C */ public WeatherEffectSpawnTypeEnum WeatherEffectSpawnType;
        /* 0x070 */ public bool RandomRotationAroundUp;
        /* 0x074 */ public float MinSpawnScale;
        /* 0x078 */ public float MaxSpawnScale;
        /* 0x07C */ public int SpawnAttemptsPerRegion;
        /* 0x080 */ public float SpawnChancePerSecondPerAttempt;
        /* 0x084 */ public float ChanceOfPlanetBeingExtreme;
        /* 0x088 */ public float SpawnChancePerSecondExtreme;
        /* 0x08C */ public float MinSpawnDistance;
        /* 0x090 */ public float MaxSpawnDistance;
        /* 0x094 */ public float MinLifetime;
        /* 0x098 */ public float MaxLifetime;
        /* 0x09C */ public float FadeoutStart;
        /* 0x0A0 */ public bool FadeoutVisuals;
        /* 0x0A1 */ public bool FadeoutAudio;
        /* 0x0A4 */ public GcAudioWwiseEvents Audio;
        /* 0x0A8 */ public NMSString0x80 ImpactGift;
        /* 0x128 */ public float ImpactGiftChance;
        /* 0x12C */ public float ClusterSpawnChance;
        /* 0x130 */ public float ClusterMinLifetime;
        /* 0x134 */ public float ClusterMaxLifetime;
        /* 0x138 */ public float PatchMaxTimeSpawnOffset;
        /* 0x13C */ public float PatchMinRadius;
        /* 0x140 */ public float PatchMaxRadius;
        /* 0x144 */ public int PatchMinSpawns;
        /* 0x148 */ public int PatchMaxSpawns;
        /* 0x14C */ public float PatchScaling;
        /* 0x150 */ public float MoveSpeed;
        /* 0x154 */ public float WanderMinRadius;
        /* 0x158 */ public float WanderMaxRadius;
        /* 0x15C */ public float WanderMinArcDeg;
        /* 0x160 */ public float WanderMaxArcDeg;
        /* 0x168 */ public NMSTemplate EffectData;
    }
}
