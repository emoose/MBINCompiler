using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAnimMetadata : NMSTemplate
    {
        public int FrameCount;
        public int NodeCount;

        public List<TkAnimNodeData> NodeData;
        public List<TkAnimNodeFrameData> AnimFrameData;

        public TkAnimNodeFrameData StillFrameData;
    }
}
