using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x30, GUID = 0x0B1830E142A34433B)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string GroupTitle;
        public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
    }
}
