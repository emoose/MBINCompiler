using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E93C2378DF7E8FFE)]
    public class TkEntitlementList : NMSTemplate
    {
        public List<NMSString0x20> Entitlements;
    }
}
