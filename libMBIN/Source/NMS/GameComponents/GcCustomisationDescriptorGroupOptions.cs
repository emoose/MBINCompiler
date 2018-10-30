using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x3EA8C94D4B6F454E, Alignment = 0x8)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupTitle;
        public bool FirstOptionIsEmpty;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding21;
        public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
    }
}
