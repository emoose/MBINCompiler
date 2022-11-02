using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x43659AB004937C51, NameHash = 0x6DFF01CC3FB67220)]
    public class TkButtonImageLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkButtonPathMapping> Lookup;
    }
}
