using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x310, GUID = 0xEDB1ADC4426FDE46, NameHash = 0x5F4CA33999F0D259)]
    public class GcExperienceSpawnTable : NMSTemplate
    {
        /* 0x000 */ public List<GcAIShipSpawnData> FlybySpawns;
        /* 0x010 */ public List<GcAIShipSpawnData> OutpostSpawns;
        /* 0x020 */ public List<GcAIShipSpawnData> SpaceFlybySpawns;
        /* 0x030 */ public List<GcAIShipSpawnData> PirateSpawns;
        /* 0x040 */ public List<GcAIShipSpawnData> PirateBattleSpawns;
        /* 0x050 */ public List<GcAIShipSpawnData> PoliceSpawns;
        /* 0x060 */ public List<GcAIShipSpawnData> TraderSpawns;
        /* 0x070 */ public List<GcAIShipSpawnData> AmbientSpawns;
        /* 0x080 */ public List<GcAIShipSpawnData> BattleSpawns;
        /* 0x090 */ public List<GcAIShipSpawnData> AbandonedFreighterSpawns;
        /* 0x0A0 */ public List<GcAIShipSpawnData> BattleInitialStandardSpawns;
        /* 0x0B0 */ public List<GcAIShipSpawnData> BattleInitialPirateSpawns;
        /* 0x0C0 */ public List<GcAIShipSpawnData> BattleSecondaryPirateSpawns;
        /* 0x0D0 */ public List<GcBountySpawnInfo> PirateBountySpawns;
        /* 0x0E0 */ public List<GcPulseEncounterInfo> PulseEncounters;
        /* 0x0F0 */ public List<GcPlayerExperienceSpawnTable> CreatureSpawnTable;
        /* 0x100 */ public List<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes;
        /* 0x110 */ public List<GcAIShipSpawnData> FrigateFlybySpawns;
        [NMS(Size = 0x6)]
        /* 0x120 */ public GcSentinelSpawnSequenceGroupList[] WantedLevelSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcEncounterType.EncounterTypeEnum))]
        /* 0x1E0 */ public GcSentinelSpawnSequenceGroupList[] EncounterSpawns;
        /* 0x2C0 */ public List<GcSentinelEncounterOverride> EncounterOverrides;
        /* 0x2D0 */ public GcSentinelnWaveGroup SummonerSpawns;
        /* 0x2F0 */ public List<GcSentinelSpawnNamedSequence> SentinelSequences;
        /* 0x300 */ public List<GcSentinelSpawnWave> SentinelSpawns;
    }
}
