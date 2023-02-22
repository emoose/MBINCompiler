using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3F327AAC7C76046, NameHash = 0xA1B202DE9A10A705)]
    public class GcPlayerExperienceSpawnTable : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Event;
        // size: 0x2
        public enum ExperienceSpawnTypeEnum {
            Freighter,
            Mission,
        }
        /* 0x10 */ public ExperienceSpawnTypeEnum ExperienceSpawnType;
        /* 0x14 */ public float ResponseRate;
        /* 0x18 */ public float PerSpawnDelay;
        /* 0x1C */ public bool Destroy;
        /* 0x20 */ public List<GcPlayerExperienceSpawnData> Spawns;
    }
}
