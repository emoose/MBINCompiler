using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0E93C2378DF7E8FFE)]
    public class TkEntitlementList : NMSTemplate
    {
        public List<NMSString0x20> Entitlements;
    }
}
