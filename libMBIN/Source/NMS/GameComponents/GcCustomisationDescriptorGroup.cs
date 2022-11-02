using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC0D219AF1DF2B8F, NameHash = 0x80953B08573D31B6)]
    public class GcCustomisationDescriptorGroup : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 GroupID;
        /* 0x010 */ public NMSString0x20A Title;
        /* 0x030 */ public NMSString0x80 Image;
        /* 0x0B0 */ public List<NMSString0x20> Descriptors;
        /* 0x0C0 */ public List<NMSString0x20> SuffixInclusionList;
        /* 0x0D0 */ public NMSString0x10 LinkedSpecialID;
        /* 0x0E0 */ public NMSString0x20A Tip;
        /* 0x100 */ public bool HiddenInCustomiser;
    }
}
