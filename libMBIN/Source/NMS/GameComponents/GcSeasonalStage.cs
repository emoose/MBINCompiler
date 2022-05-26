using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xD8, GUID = 0x55B6DD893A0EA6A6, NameHash = 0xF1949393FDAF963A)]
    public class GcSeasonalStage : NMSTemplate
    {
        /* 0x00 */ public List<GcSeasonalMilestone> Milestones;
        /* 0x10 */ public TkTextureResource Icon;
        /* 0x98 */ public NMSString0x20A Title;
        /* 0xB8 */ public NMSString0x20A Description;
    }
}
