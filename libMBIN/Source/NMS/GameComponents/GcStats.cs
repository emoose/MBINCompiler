using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x571AB2CD847CE0A6, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
