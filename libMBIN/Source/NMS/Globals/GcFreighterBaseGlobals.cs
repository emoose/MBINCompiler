using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x98, GUID = 0xB85EBBD6B73B284E, NameHash = 0xCB9E3321AA0276BD)]
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
