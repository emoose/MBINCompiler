using System.Collections.Generic;

namespace MBINCompiler.Models.Structs       // size: 0xD8
{
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string Type;
        /* 0x90 */ public TkTransformData Transform;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xB4 */ public byte[] PaddingB4;
        /* 0xB8 */ public List<TkSceneNodeAttributeData> Attributes;
        /* 0xC8 */ public List<TkSceneNodeData> Children;
    }
}
