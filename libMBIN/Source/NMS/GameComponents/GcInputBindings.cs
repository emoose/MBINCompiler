using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE888AC6CAD2C79D3, SubGUID = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        public List<GcInputBindingSet> InputBindingSets;
    }
}
