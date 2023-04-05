using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEFE60C8B4F5A3ED, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x36, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x51000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x52950 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
