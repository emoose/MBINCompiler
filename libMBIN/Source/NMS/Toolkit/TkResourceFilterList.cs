using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD292EC640A03C7BF, NameHash = 0x84DCB310035A7429)]
    public class TkResourceFilterList : NMSTemplate
    {
        /* 0x0 */ public List<TkResourceFilterData> Filters;
    }
}
