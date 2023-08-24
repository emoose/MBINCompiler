using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B1A59246EC1D467, NameHash = 0xB021B7904E5ECE5D)]
    public class GcCustomisationDescriptorGroupFallbackData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DescriptorGroupID;
        /* 0x10 */ public List<NMSString0x10> FallbackPriorityList;
    }
}
