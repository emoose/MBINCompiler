using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3A5019696FD699AB)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        public List<GcPurchaseableSpecial> Table;
    }
}
