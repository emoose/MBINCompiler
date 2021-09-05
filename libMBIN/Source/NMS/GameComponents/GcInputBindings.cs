using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x16F914D1FED88AE0, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        public List<GcInputBindingSet> InputBindingSets;
    }
}