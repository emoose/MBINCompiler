using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x3D64F1BA7F46E9B8)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
