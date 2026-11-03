using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEF1ED7B112DE9181, NameHash = 0xDDAD118A)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkSceneBoneRemapping> BoneMappings;
    }
}
