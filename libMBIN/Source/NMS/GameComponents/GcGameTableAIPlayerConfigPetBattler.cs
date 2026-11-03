using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DAF72D8ECBD6965, NameHash = 0x37C8CBC2)]
    public class GcGameTableAIPlayerConfigPetBattler : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x3)]
        /* 0x00 */ public GcGameTableAIPlayerPetConfig[] Pets;
        [NMS(Index = 1)]
        /* 0x78 */ public GcSeed CustomTeamSeed;
        [NMS(Index = 2)]
        /* 0x88 */ public NMSString0x10 SeedMissionId;
        // size: 0x4
        public enum PetBattleAITeamSeedSourceEnum : uint {
            NPC,
            NPCAndWins,
            Mission,
            Custom,
        }
        [NMS(Index = 0)]
        /* 0x98 */ public PetBattleAITeamSeedSourceEnum PetBattleAITeamSeedSource;
    }
}
