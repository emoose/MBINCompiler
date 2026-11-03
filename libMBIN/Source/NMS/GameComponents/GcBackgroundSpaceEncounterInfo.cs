using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AE4D9A1839CFD41, NameHash = 0x37EBD7AD)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcPulseEncounterSpawnObject Encounter;
        [NMS(Index = 1)]
        /* 0x78 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 0)]
        /* 0x98 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0xA8 */ public float DespawnDistance;
        [NMS(Index = 5)]
        /* 0xAC */ public float MinDuration;
        [NMS(Index = 2)]
        /* 0xB0 */ public float SelectionWeighting;
        [NMS(Index = 3)]
        /* 0xB4 */ public float SpawnChance;
        [NMS(Index = 4)]
        /* 0xB8 */ public float SpawnDistance;
    }
}
