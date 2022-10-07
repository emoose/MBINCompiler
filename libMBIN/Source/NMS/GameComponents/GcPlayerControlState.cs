using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B6FF6A21FB26D5F, NameHash = 0x9CBA2290362425C1)]
    public class GcPlayerControlState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool StickToGround;
        /* 0x18 */ public GcPlayerControlInput OverrideInput;
        /* 0x50 */ public NMSString0x10 OverrideCamera;
        /* 0x60 */ public List<NMSTemplate> Data;
    }
}
