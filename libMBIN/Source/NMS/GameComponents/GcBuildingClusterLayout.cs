using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B1B7EF6F13A3928, NameHash = 0x93FF0D35)]
    public class GcBuildingClusterLayout : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcBuildingClusterLayoutEntry> ClusterBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ID;
        [NMS(Index = 4, MxmlName = "Alignment Jitter")]
        /* 0x20 */ public float AlignmentJitter;
        [NMS(Index = 3, MxmlName = "Alignment Steps")]
        /* 0x24 */ public int AlignmentSteps;
        [NMS(Index = 1)]
        /* 0x28 */ public float RelativeProbability;
    }
}
