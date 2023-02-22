using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92F0F711498404A4, NameHash = 0x52AAFE72AAC465AE)]
    public class GcInputBindingSet : NMSTemplate
    {
        /* 0x0 */ public GcActionSetType Type;
        /* 0x8 */ public List<GcInputBinding> InputBindings;
    }
}
