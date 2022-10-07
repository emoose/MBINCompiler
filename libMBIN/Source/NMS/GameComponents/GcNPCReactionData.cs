using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31D8EAFAAE2B4184, NameHash = 0xA83B1CD89A122A08)]
    public class GcNPCReactionData : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCReactionEntry> Reactions;
    }
}
