using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5168F2DA9CA11CE1, NameHash = 0x39D3AB42)]
    public class GcCustomisationDescriptorGroupFallbackData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DescriptorGroupID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> FallbackPriorityList;
    }
}
