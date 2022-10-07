using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9371B32161E1830C, NameHash = 0x2C1B6B0E807F7193)]
    public class TkSceneNodeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Name;
        /* 0x80 */ public uint NameHash;
        /* 0x88 */ public NMSString0x10 Type;
        /* 0x98 */ public TkTransformData Transform;
        /* 0xC0 */ public List<TkSceneNodeAttributeData> Attributes;
        /* 0xD0 */ public List<TkSceneNodeData> Children;
    }
}
