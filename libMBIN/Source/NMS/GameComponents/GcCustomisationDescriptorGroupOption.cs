using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x43253C7E8F48B915)]
    public class GcCustomisationDescriptorGroupOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string DescriptorOption;
        public List<GcCustomisationTextureGroup> TextureGroups;
        public bool ReplaceBaseColours;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding21;
        public List<GcCustomisationColourGroup> ColourGroups;
    }
}
