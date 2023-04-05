using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC711BF4CE600E732, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
