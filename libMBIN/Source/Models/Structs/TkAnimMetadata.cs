using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkAnimMetadata : NMSTemplate       // size: 0x58
    {
        public int FrameCount;
        public int NodeCount;

        public List<TkAnimNodeData> NodeData;
        public List<TkAnimNodeFrameData> AnimFrameData;

        public TkAnimNodeFrameData StillFrameData;
    }
}
