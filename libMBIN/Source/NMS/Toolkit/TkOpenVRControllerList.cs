using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D2192311E42199C, NameHash = 0x9BF04097261BBFEA)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        /* 0x0 */ public List<TkOpenVRControllerLookup> Devices;
    }
}
