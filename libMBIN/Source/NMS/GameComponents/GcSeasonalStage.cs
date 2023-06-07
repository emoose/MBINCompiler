using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53539879812A195B, NameHash = 0xF1949393FDAF963A)]
    public class GcSeasonalStage : NMSTemplate
    {
        /* 0x00 */ public List<GcSeasonalMilestone> Milestones;
        /* 0x10 */ public NMSString0x20A Title;
        /* 0x30 */ public NMSString0x20A Description;
    }
}
