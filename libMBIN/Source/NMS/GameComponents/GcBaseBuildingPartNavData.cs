using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5129629C3FC2E8D, NameHash = 0xE1F61A258ED99443)]
    public class GcBaseBuildingPartNavData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A PartID;
        /* 0x20 */ public List<GcBaseBuildingPartInteractionData> SharedInteractions;
        /* 0x30 */ public List<GcBaseBuildingPartNavNodeData> NavNodeData;
    }
}
