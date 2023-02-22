using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19E797FB82481381, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
