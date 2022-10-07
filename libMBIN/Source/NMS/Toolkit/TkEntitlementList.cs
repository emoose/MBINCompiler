using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE93C2378DF7E8FFE, NameHash = 0x6DD030A653A9BBF2)]
    public class TkEntitlementList : NMSTemplate
    {
        /* 0x0 */ public List<TkEntitlementListData> Entitlements;
    }
}
