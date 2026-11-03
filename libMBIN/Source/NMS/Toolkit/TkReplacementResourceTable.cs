using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x50BC508B6C3D3187, NameHash = 0x52649D7F)]
    public class TkReplacementResourceTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkReplacementResource> Data;
    }
}
