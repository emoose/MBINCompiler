using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD52EA8B2A261D7, NameHash = 0x70622F0C8DD198C)]
    public class GcSpringAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 Name;
        /* 0x48 */ public List<GcSpringLink> SpringLinks;
    }
}
