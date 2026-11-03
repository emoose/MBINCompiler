using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x96FF0E9418D14814, NameHash = 0x4026294F)]
    public class TkModelDescriptorList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceDescriptorList> List;
    }
}
