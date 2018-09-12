using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0D0EAD3840328781D)]
    public class GcFrigateTraitTable : NMSTemplate
    {
        public List<GcFrigateTraitData> Traits;
    }
}
