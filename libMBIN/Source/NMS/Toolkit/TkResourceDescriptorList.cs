using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6B2689B74FDE1107, NameHash = 0x6E58FF6D49923F40)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TypeId;
        /* 0x10 */ public List<TkResourceDescriptorData> Descriptors;
    }
}
