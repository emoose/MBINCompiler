using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x3CD7D2192958BA6C)]
    public class TkAnimMetadata : NMSTemplate       // size: 0x58
    {
        public int FrameCount;
        public int NodeCount;

        public List<TkAnimNodeData> NodeData;
        public List<TkAnimNodeFrameData> AnimFrameData;

        public TkAnimNodeFrameData StillFrameData;
    }
}
