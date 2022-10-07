using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x68DDDBFC00E41FCE, NameHash = 0xAF2831AAF7DE1710)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        /* 0x0 */ public List<TkSceneBoneRemapping> BoneMappings;
    }
}
