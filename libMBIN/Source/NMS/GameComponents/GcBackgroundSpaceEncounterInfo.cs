using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57D664ECDFC788E7, NameHash = 0x9803054FC61F20F4)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        /* 0x28 */ public float SelectionWeighting;
        /* 0x2C */ public float SpawnChance;
        /* 0x30 */ public float SpawnDistance;
        /* 0x34 */ public float MinDuration;
        /* 0x38 */ public float DespawnDistance;
        /* 0x40 */ public GcPulseEncounterSpawnObject Encounter;
    }
}
