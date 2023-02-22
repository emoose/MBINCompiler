using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E4B94C6A2E76DCD, NameHash = 0x1DC53C6BE7A69854)]
    public class GcCustomisationGroups : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationGroup> CustomisationGroups;
    }
}
