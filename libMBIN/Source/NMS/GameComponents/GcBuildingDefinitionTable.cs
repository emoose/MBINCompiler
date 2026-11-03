using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49BC3C5B043A6DF3, NameHash = 0xFD3342FE)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x2760 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Index = 2)]
        /* 0xFC00 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
