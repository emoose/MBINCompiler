using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8FCA4C586CEF8D34, NameHash = 0x64CA3907BFF31DA)]
    public class TkAnimMetadata : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimNodeData> NodeData;
        /* 0x10 */ public List<TkAnimNodeFrameData> AnimFrameData;
        /* 0x20 */ public TkAnimNodeFrameData StillFrameData;
        /* 0x50 */ public int FrameCount;
        /* 0x54 */ public int NodeCount;
        /* 0x58 */ public bool Has30HzFrames;
    }
}
