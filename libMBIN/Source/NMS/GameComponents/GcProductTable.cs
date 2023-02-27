using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4815B0C33757F951, NameHash = 0x7A62ED648FC514F7)]
    public class GcProductTable : NMSTemplate
    {
        /* 0x0 */ public List<GcProductData> Table;
    }
}
