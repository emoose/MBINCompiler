using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63C53898A2402C7C, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
