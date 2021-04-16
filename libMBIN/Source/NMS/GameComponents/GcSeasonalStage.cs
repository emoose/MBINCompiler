using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xD8, GUID = 0x36FC71E993158B0A, NameHash = 0xF1949393FDAF963A)]
    public class GcSeasonalStage : NMSTemplate
    {
        /* 0x00 */ public List<GcSeasonalMilestone> Milestones;
        /* 0x10 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] Padding94;
        [NMS(Size = 0x20)]
        /* 0x98 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0xB8 */ public string Description;
    }
}
