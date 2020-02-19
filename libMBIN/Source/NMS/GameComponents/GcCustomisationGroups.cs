using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF0257C49A45B03D0, NameHash = 0x1DC53C6BE7A69854)]
    public class GcCustomisationGroups : NMSTemplate
    {
        public List<GcCustomisationGroup> CustomisationGroups;
    }
}
