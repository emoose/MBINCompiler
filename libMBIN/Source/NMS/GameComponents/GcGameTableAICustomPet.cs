using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x779B0AC33E77E994, NameHash = 0xCA27AD7F)]
    public class GcGameTableAICustomPet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureID;
        [NMS(Index = 2)]
        /* 0x10 */ public GcSeed ForceSeed;
        [NMS(Index = 1)]
        /* 0x20 */ public int ForceLevel;
        // size: 0x4
        public enum GameTableAICustomPetAffinityTypeEnum : uint {
            Random,
            FromPlanet,
            FromSystem,
            Custom,
        }
        [NMS(Index = 4)]
        /* 0x24 */ public GameTableAICustomPetAffinityTypeEnum GameTableAICustomPetAffinityType;
        [NMS(Index = 3)]
        /* 0x28 */ public NMSString0x20 Name;
        [NMS(Index = 5)]
        /* 0x48 */ public GcPetBattlerAffinity CustomAffinity;
    }
}
