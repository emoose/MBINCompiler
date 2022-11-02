using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x408828F957889A6B, NameHash = 0xCB9E3321AA0276BD)]
    public class GcFreighterBaseGlobals : NMSTemplate
    {
        /* 0x00 */ public int MaxTotalNPCCount;
        /* 0x04 */ public float NPCStartSpawnDelayTime;
        /* 0x08 */ public float NPCSpawnIntervalTime;
        /* 0x0C */ public float MinTotalRoomsRequiredPerNPC;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x10 */ public int[] MaxTotalCapacityOfNPCTypes;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x28 */ public GcFreighterNPCSpawnPriority[] NPCTypeSpawnPriorities;
        /* 0x78 */ public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity;
        /* 0x88 */ public List<GcFreighterRoomNPCData> FreighterRoomNPCData;
    }
}
