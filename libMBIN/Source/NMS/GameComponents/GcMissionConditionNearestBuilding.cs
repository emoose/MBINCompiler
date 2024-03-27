using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ED0E27CAF188CEA, NameHash = 0x116C1EDD24B089D5)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x4 */ public float Distance;
        /* 0x8 */ public List<GcBuildingClassification> AdditionalBuildings;
    }
}
