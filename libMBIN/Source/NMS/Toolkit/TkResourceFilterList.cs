using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEFB0074C0F5CFD01, NameHash = 0xBE05474C)]
    public class TkResourceFilterList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceFilterData> Filters;
    }
}
