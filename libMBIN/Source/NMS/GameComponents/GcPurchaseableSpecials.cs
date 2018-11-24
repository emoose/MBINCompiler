using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE430B92BA2F7D3E)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        public List<GcPurchaseableSpecial> Table;
    }
}
