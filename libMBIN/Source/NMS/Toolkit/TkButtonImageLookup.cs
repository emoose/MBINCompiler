using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF0F29F2388E0DF57, NameHash = 0x9219269B)]
    public class TkButtonImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkButtonPathMapping> Lookup;
    }
}
