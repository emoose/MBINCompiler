using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x9A660, GUID = 0xE2224B63F1C9F55E, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x99000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x9A650 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
