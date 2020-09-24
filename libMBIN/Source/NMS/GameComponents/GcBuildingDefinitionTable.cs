using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48D80, GUID = 0x1943BC4879B0C62B, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;

        [NMS(Size = 0x24, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x48000 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
