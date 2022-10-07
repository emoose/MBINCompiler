using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB22E1ABAB4CBE5F8, NameHash = 0x72C48F33F8324A08)]
    public class TkModelDescriptorList : NMSTemplate
    {
        /* 0x0 */ public List<TkResourceDescriptorList> List;
    }
}
