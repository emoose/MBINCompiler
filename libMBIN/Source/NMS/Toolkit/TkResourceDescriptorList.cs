using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x328BC8722EB81B1F, NameHash = 0x6E58FF6D49923F40)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TypeId;
        /* 0x10 */ public List<TkResourceDescriptorData> Descriptors;
    }
}
