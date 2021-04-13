using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x0000000000000000, NameHash = 0x342DA8D8BE5A9CE3)]
    public class GcMissileComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Explosion;
        /* 0x10 */ public float NoTargetLife;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string Trail;
    }
}
