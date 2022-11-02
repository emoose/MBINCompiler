using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3FF2E2C0BEEA3AB6, NameHash = 0x64CA3907BFF31DA)]
    public class TkAnimMetadata : NMSTemplate
    {
        /* 0x00 */ public int FrameCount;
        /* 0x04 */ public int NodeCount;
        /* 0x08 */ public List<TkAnimNodeData> NodeData;
        /* 0x18 */ public List<TkAnimNodeFrameData> AnimFrameData;
        /* 0x28 */ public TkAnimNodeFrameData StillFrameData;
    }
}
