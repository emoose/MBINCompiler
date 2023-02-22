using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9222F3D64367B8B5, NameHash = 0xF1949393FDAF963A)]
    public class GcSeasonalStage : NMSTemplate
    {
        /* 0x00 */ public List<GcSeasonalMilestone> Milestones;
        /* 0x10 */ public TkTextureResource Icon;
        /* 0x98 */ public NMSString0x20A Title;
        /* 0xB8 */ public NMSString0x20A Description;
    }
}
