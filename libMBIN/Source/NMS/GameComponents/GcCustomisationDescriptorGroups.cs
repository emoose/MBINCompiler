using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7A72E7BB00841BC, NameHash = 0xB84E1949AA2825A6)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
