using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0xE93C2378DF7E8FFE, NameHash = 0x6DD030A653A9BBF2)]
    public class TkEntitlementList : NMSTemplate
    {
        public List<TkEntitlementListData> Entitlements;
    }
}