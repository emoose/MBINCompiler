using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0x0000000000000000, NameHash = 0xF81E00514EB73ED9)]
    public class GcCreatureDiscoveryThumbnailOverride : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string ContainsDescriptor;
        /* 0x20 */ public float DiscoveryUIScaler;
        /* 0x30 */ public Vector3f DiscoveryUIOffset;
    }
}
