using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA009BEF9B199E19, NameHash = 0xAE95337199B47CD)]
    public class GcBaseBuildingPartNavNodeData : NMSTemplate
    {
        /* 0x00 */ public GcNPCNavSubgraphNodeType Type;
        /* 0x10 */ public Vector3f LocalPos;
        /* 0x20 */ public float ArriveDist;
        /* 0x30 */ public Vector3f AtDir;
        /* 0x40 */ public NMSString0x10 InteractionID;
        /* 0x50 */ public List<uint> ConnectedNodeIndices;
    }
}
