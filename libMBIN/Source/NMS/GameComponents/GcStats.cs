using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x248F014942FD5940, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
