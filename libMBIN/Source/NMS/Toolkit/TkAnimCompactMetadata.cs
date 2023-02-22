using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4BFF64F3341B71C2, NameHash = 0x8D1F8DB67274D95A)]
    public class TkAnimCompactMetadata : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimNodeData> NodeData;
        /* 0x10 */ public List<TkAnimNodeFrameHalfData> AnimFrameData;
        /* 0x20 */ public TkAnimNodeFrameHalfData StillFrameData;
        /* 0x50 */ public int FrameCount;
        /* 0x54 */ public int NodeCount;
        /* 0x58 */ public bool Has30HzFrames;
    }
}
