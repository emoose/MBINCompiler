using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x581C5DD9F4C48F51, NameHash = 0x2512A16D)]
    public class GcNPCColourTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCColourGroup> Groups;
    }
}
