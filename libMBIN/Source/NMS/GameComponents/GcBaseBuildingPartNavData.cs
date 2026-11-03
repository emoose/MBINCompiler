using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5310F7C881B54E60, NameHash = 0x8065BADE)]
    public class GcBaseBuildingPartNavData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A PartID;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcBaseBuildingPartNavNodeData> NavNodeData;
        [NMS(Index = 1)]
        /* 0x30 */ public List<GcBaseBuildingPartInteractionData> SharedInteractions;
    }
}
