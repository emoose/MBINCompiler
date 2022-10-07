using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCA2BAAB3036EAD9E, NameHash = 0x6A1494CD3EC019B6)]
    public class TkAxisImageLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkAxisPathMapping> Lookup;
    }
}
