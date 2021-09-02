using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x9A7F8, GUID = 0x68D79047DA1A0FE5, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x99000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x9A7E8 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
