using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA2E65C15010EAC1, NameHash = 0x7D347F979E52A1C1)]
    public class GcActionSets : NMSTemplate
    {
        /* 0x0 */ public List<GcActionSet> ActionSets;
    }
}
