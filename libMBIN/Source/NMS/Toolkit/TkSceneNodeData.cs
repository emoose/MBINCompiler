using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit       // size: 0xD8
{
	[NMS(GUID = 0x0D5756F96B501B8A2)]
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
