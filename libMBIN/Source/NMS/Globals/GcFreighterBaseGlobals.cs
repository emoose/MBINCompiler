using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x6CD970039C9D523, NameHash = 0xCB9E3321AA0276BD)]
    public class GcFreighterBaseGlobals : NMSTemplate
    {
        /* 0x00 */ public int MaxTotalNPCCount;
        /* 0x04 */ public float NPCStartSpawnDelayTime;
        /* 0x08 */ public float NPCSpawnIntervalTime;
        /* 0x0C */ public float MinTotalRoomsRequiredPerNPC;
        // size: 0x5
        public enum MaxTotalCapacityOfNPCTypesEnum {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry
        }
        [NMS(Size = 0x5, EnumType = typeof(MaxTotalCapacityOfNPCTypesEnum))]
        /* 0x10 */ public int[] MaxTotalCapacityOfNPCTypes;
        // size: 0x5
        public enum NPCTypeSpawnPrioritiesEnum {
            SquadronPilot,
            FrigateCaptain,
            WorkerBio,
            WorkerTech,
            WorkerIndustry
        }
        [NMS(Size = 0x5, EnumType = typeof(NPCTypeSpawnPrioritiesEnum))]
        /* 0x28 */ public GcFreighterNPCSpawnPriority[] NPCTypeSpawnPriorities;
        /* 0x78 */ public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity;
        /* 0x88 */ public List<GcFreighterRoomNPCData> FreighterRoomNPCData;
    }
}
