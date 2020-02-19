using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x7369AA0D0B9559FD, Alignment = 0x8, NameHash = 0x57CBFDF164E923E9)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string GroupTitle;
        /* 0x20 */ public bool FirstOptionIsEmpty;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        /* 0x28 */ public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;

    }
}
