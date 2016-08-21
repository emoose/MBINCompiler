using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkSceneNodeData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Type;
        public TkTransformData Transform;
        public uint EmptyNode1;
        public List<TkSceneNodeAttributeData> Attributes;
        public List<TkSceneNodeData> Children;
    }
}
