using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEB8DC91C6007A0C0, NameHash = 0x9BF04097261BBFEA)]
    public class TkOpenVRControllerList : NMSTemplate
    {
        /* 0x0 */ public List<TkOpenVRControllerLookup> Devices;
    }
}
