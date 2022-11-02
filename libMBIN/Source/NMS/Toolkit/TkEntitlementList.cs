using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAAA4E4FFCB8A2BE9, NameHash = 0x6DD030A653A9BBF2)]
    public class TkEntitlementList : NMSTemplate
    {
        /* 0x0 */ public List<TkEntitlementListData> Entitlements;
    }
}
