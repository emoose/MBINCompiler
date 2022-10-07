using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF6AEDCB258E2CFC1, NameHash = 0xB015A154CC664705)]
    public class TkResourceFilterData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 FilterName;
        /* 0x10 */ public List<NMSString0x20A> FilteredResources;
    }
}
