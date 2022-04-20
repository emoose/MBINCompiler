using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x16F914D1FED88AE0, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
