using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA62AEE27A793FD03, NameHash = 0xAF2831AAF7DE1710)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        /* 0x0 */ public List<TkSceneBoneRemapping> BoneMappings;
    }
}
