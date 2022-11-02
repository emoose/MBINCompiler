using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2225CAABA327449F, NameHash = 0xBE4097172440769E)]
    public class TkSketchComponentData : NMSTemplate
    {
        /* 0x00 */ public float GraphPosX;
        /* 0x04 */ public float GraphPosY;
        /* 0x08 */ public float GraphZoom;
        /* 0x0C */ public float UpdateRateMultiplier;
        /* 0x10 */ public List<TkSketchNodeData> Nodes;
    }
}
