using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD141FC9D7A9AB34, NameHash = 0x116C1EDD24B089D5)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x4 */ public float Distance;
        /* 0x8 */ public List<GcBuildingClassification> AdditionalBuildings;
    }
}
