using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF77E0A244BC5D465, NameHash = 0xCD3CFB61BDAFF633)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        /* 0x0 */ public List<GcPurchaseableSpecial> Table;
    }
}
