using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8D1CCC0BEA7A50B0, NameHash = 0xB015A154CC664705)]
    public class TkResourceFilterData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 FilterName;
        /* 0x10 */ public List<NMSString0x20A> FilteredResources;
    }
}
