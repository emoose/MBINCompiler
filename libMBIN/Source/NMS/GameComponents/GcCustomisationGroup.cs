using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x867D5B3F13938F63, NameHash = 0xB5A01AE676FD46D)]
    public class GcCustomisationGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupID;
        /* 0x10 */ public NMSString0x20A GroupTitle;
        /* 0x30 */ public bool IsBannerGroup;
        /* 0x31 */ public bool ForceShowAllColourOptions;
        /* 0x34 */ public GcCustomisationCameraData CameraData;
        /* 0x68 */ public List<GcCustomisationDescriptorGroupOptions> DescriptorOptions;
        /* 0x78 */ public List<GcCustomisationTextureGroup> TextureGroups;
        /* 0x88 */ public List<GcCustomisationColourGroup> ColourGroups;
        /* 0x98 */ public List<GcCustomisationBoneScales> BoneScales;
    }
}
