using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0383134FAEA1198, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
