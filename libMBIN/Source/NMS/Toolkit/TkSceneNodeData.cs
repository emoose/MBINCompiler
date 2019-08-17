using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9371B32161E1830C, Size = 0xE0, SubGUID = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Name;
        /* 0x80 */ public ulong NameHash;   // not really sure about this...
        [NMS(Size = 0x10)]
        /* 0x88 */ public string Type;
        /* 0x98 */ public TkTransformData Transform;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBC */ public byte[] PaddingBC;
        /* 0xC0 */ public List<TkSceneNodeAttributeData> Attributes;
        /* 0xD0 */ public List<TkSceneNodeData> Children;
    }
}
