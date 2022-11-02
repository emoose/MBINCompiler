using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x49D91C8107D6965C, NameHash = 0x52912F535A46A50C)]
    public class TkRagdollData : NMSTemplate
    {
        /* 0x00 */ public float Density;
        /* 0x04 */ public float Gravity;
        /* 0x08 */ public List<NMSString0x20> ChainEnds;
        /* 0x18 */ public List<NMSString0x20> ExcludeJoints;
    }
}
