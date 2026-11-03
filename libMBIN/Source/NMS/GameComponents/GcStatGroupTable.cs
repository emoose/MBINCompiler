using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8E3FD964F6709FE, NameHash = 0x2219C319)]
    public class GcStatGroupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatGroupData> StatGroupTable;
    }
}
