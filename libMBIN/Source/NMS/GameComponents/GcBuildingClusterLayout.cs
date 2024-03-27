using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA48014C40FE98AE7, NameHash = 0x8A9F48B72B9E5588)]
    public class GcBuildingClusterLayout : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float RelativeProbability;
        /* 0x18 */ public List<GcBuildingClusterLayoutEntry> ClusterBuildings;
        /* 0x28 */ public int AlignmentSteps;
        /* 0x2C */ public float AlignmentJitter;
    }
}
