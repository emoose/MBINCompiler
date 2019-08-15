using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x6DF5134EBBBBE7DC)]
    public class GcCustomisationGroups : NMSTemplate
    {
        public List<GcCustomisationGroup> CustomisationGroups;
    }
}
