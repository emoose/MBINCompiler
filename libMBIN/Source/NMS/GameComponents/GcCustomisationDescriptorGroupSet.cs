using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15F87A47037F31FA, NameHash = 0xDF74971999421442)]
    public class GcCustomisationDescriptorGroupSet : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
