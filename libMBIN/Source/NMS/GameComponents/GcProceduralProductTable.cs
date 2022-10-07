using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71B7F36157239F99, NameHash = 0x9A0073340429C464)]
    public class GcProceduralProductTable : NMSTemplate
    {
        // size: 0x1A
        public enum TableEnum {
            Loot,
            Document,
            BioSample,
            Fossil,
            Plant,
            Tool,
            Farm,
            SeaLoot,
            SeaHorror,
            Salvage,
            Bones,
            SpaceHorror,
            SpaceBones,
            FreighterPassword,
            FreighterCaptLog,
            FreighterCrewList,
            FreighterTechHyp,
            FreighterTechSpeed,
            FreighterTechFuel,
            FreighterTechTrade,
            FreighterTechCombat,
            FreighterTechMine,
            FreighterTechExp,
            DismantleBio,
            DismantleTech,
            DismantleData
        }
        [NMS(Size = 0x1A, EnumType = typeof(TableEnum))]
        /* 0x0 */ public GcProceduralProductData[] Table;
    }
}
