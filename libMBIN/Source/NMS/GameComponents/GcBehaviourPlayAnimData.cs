using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8B574543FC643C2, NameHash = 0xBFB26332AE955464)]
    public class GcBehaviourPlayAnimData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public float BlendInTime;
        /* 0x14 */ public float BlendOutAt;
        /* 0x18 */ public List<GcBehaviourPlayAnimTrigger> Triggers;
    }
}
