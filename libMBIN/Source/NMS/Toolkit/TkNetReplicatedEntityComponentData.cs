using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2A966EB68A4B77C, NameHash = 0xDB0FD87A0597E5FD)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x80> ReplicaComponentMask;
        // size: 0x8
        public enum ReplicationRangeEnum {
            NotSet,
            System,
            SystemLocal,
            Planet,
            PlanetLocal,
            Space,
            SpaceStation,
            Nexus,
        }
        /* 0x10 */ public ReplicationRangeEnum ReplicationRange;
        // size: 0x2
        public enum SpawnTypeEnum {
            Basic,
            Creature,
        }
        /* 0x14 */ public SpawnTypeEnum SpawnType;
        /* 0x18 */ public bool IgnoreComponents;
    }
}
