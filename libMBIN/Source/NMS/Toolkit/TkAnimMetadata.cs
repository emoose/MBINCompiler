using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA2744D2D181CDEC5, NameHash = 0x8E7F1986)]
    public class TkAnimMetadata : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkAnimNodeFrameData StillFrameData;
        [NMS(Index = 1)]
        /* 0x30 */ public List<TkAnimNodeFrameData> AnimFrameData;
        [NMS(Index = 0)]
        /* 0x40 */ public List<TkAnimNodeData> NodeData;
        [NMS(Index = 3)]
        /* 0x50 */ public int FrameCount;
        [NMS(Index = 4)]
        /* 0x54 */ public int NodeCount;
        [NMS(Index = 5)]
        /* 0x58 */ public bool Has30HzFrames;
    }
}
