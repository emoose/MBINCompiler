using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x21A170CB7D6E2605)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string DescriptorOption;
        public List<GcCustomisationTextureGroup> TextureGroups;
        public List<GcCustomisationColourGroup> ColourGroups;
    }
}
