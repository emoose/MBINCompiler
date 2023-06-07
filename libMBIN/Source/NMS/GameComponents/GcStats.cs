using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5A74DB5CC6E0C7D, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
