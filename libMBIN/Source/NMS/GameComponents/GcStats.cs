using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xFD81581FD9E32DB7, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
