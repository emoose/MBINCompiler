using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBD87AB92DC14AE9, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        /* 0x000 */ public List<GcAIShipSpawnData> FlybySpawns;
        /* 0x010 */ public List<GcAIShipSpawnData> OutpostSpawns;
        /* 0x020 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        /* 0x030 */ public List<GcAIShipSpawnData> MiningFlybySpawns;
        /* 0x040 */ public List<GcAIShipSpawnData> PirateSpawns;
        /* 0x050 */ public List<GcAIShipSpawnData> PlanetaryPirateFlybySpawns;
        /* 0x060 */ public List<GcAIShipSpawnData> PlanetaryPirateRaidSpawns;
        /* 0x070 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        /* 0x080 */ public List<GcPoliceSpawnWaveData> PoliceSpawns;
        /* 0x090 */ public List<GcAIShipSpawnData> TraderSpawns;
        /* 0x0A0 */ public List<GcAIShipSpawnData> AmbientSpawns;
        /* 0x0B0 */ public List<GcAIShipSpawnData> BattleSpawns;
        /* 0x0C0 */ public List<GcAIShipSpawnData> BattlePirateSpawns;
        /* 0x0D0 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        /* 0x0E0 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        /* 0x0F0 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        /* 0x100 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        /* 0x110 */ public List<GcAIShipSpawnData> BattleRecurringPirateSpawns;
        /* 0x120 */ public GcAIShipSpawnData BattleReinforcingPirateFrigateSpawn;
        /* 0x300 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        /* 0x310 */ public List<GcPulseEncounterInfo> PulseEncounters;
        /* 0x320 */ public List<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters;
        /* 0x330 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        /* 0x340 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        /* 0x350 */ public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns;
        /* 0x398 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        [NMS(Size = 0x6)]
        /* 0x3A8 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        [NMS(Size = 0x8, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x4C8 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        /* 0x648 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        /* 0x658 */ public GcSentinelWaveGroup SummonerSpawns;
        /* 0x678 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        /* 0x688 */ public List<GcSentinelSpawnWave> SentinelSpawns;
    }
}
