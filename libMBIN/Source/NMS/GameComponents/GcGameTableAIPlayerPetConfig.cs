using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x839949D9FD851364, NameHash = 0xDC296502)]
    public class GcGameTableAIPlayerPetConfig : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcGameTableAICustomPet> CustomPetPool;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxLevel;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinLevel;
        // size: 0x4
        public enum PetBattlerAIPetPoolEnum : uint {
            All,
            FromPlanet,
            FromSystem,
            Custom,
        }
        [NMS(Index = 0)]
        /* 0x18 */ public PetBattlerAIPetPoolEnum PetBattlerAIPetPool;
        [NMS(Index = 3, Size = 0x9, EnumType = typeof(GcPetBattlerAffinity.PetBattlerAffinityEnum))]
        /* 0x1C */ public bool[] AllowedAffinities;
    }
}
