using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x694EA2A8ACF29BCB, NameHash = 0xB84E1949AA2825A6)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
