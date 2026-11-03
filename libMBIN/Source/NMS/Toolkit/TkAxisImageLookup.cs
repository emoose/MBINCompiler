using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8BC25D767F23285D, NameHash = 0x330ED410)]
    public class TkAxisImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAxisPathMapping> Lookup;
    }
}
