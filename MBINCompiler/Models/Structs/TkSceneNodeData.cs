using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x10)]
        public string Type;
        public TkTransformData Transform;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        public List<TkSceneNodeAttributeData> Attributes;
        public List<TkSceneNodeData> Children;
    }
}
