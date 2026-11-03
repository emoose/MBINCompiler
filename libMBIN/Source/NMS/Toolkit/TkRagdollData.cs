using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC8AA3DBA947B58C6, NameHash = 0xAA0A463F)]
    public class TkRagdollData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x20> ChainEnds;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x20> ExcludeJoints;
    }
}
