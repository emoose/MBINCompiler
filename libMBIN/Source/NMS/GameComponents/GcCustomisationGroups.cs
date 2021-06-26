using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xD30AE68420A6F7CF, NameHash = 0x1DC53C6BE7A69854)]
    public class GcCustomisationGroups : NMSTemplate
    {
        public List<GcCustomisationGroup> CustomisationGroups;
    }
}
