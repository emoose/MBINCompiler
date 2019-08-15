using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xB927B88D024EDD82, SubGUID = 0xA29C133FB960AEB2)]
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
