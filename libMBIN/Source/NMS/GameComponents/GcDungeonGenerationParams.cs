using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA790A943816F13C, NameHash = 0xFD9E29934900184E)]
    public class GcDungeonGenerationParams : NMSTemplate
    {
        /* 0x00 */ public uint SizeX;
        /* 0x04 */ public uint SizeY;
        /* 0x08 */ public uint SizeZ;
        /* 0x0C */ public uint EntranceX;
        /* 0x10 */ public uint EntranceY;
        /* 0x14 */ public uint EntranceZ;
        /* 0x18 */ public uint Rooms;
        /* 0x1C */ public float XProbability;
        /* 0x20 */ public float YProbability;
        /* 0x24 */ public float ZProbability;
        /* 0x28 */ public float StraightMultiplier;
        /* 0x30 */ public List<GcDungeonRoomParams> MainRoomTypes;
        /* 0x40 */ public List<NMSString0x10> BranchRoomTypes;
        /* 0x50 */ public List<GcDungeonQuestParams> Quests;
        /* 0x60 */ public List<NMSTemplate> GenerationRules;
        /* 0x70 */ public List<NMSString0x10> PruningRules;
    }
}
