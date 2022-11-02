using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB29F2A8FD13A46A5, NameHash = 0x52AAFE72AAC465AE)]
    public class GcInputBindingSet : NMSTemplate
    {
        /* 0x0 */ public GcActionSetType Type;
        /* 0x8 */ public List<GcInputBinding> InputBindings;
    }
}
