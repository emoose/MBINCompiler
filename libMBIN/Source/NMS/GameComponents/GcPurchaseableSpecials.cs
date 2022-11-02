using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6455EA88765A2AE6, NameHash = 0xCD3CFB61BDAFF633)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        /* 0x0 */ public List<GcPurchaseableSpecial> Table;
    }
}
