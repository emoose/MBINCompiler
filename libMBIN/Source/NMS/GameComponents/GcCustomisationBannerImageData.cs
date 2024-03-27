using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD574FC0402980788, NameHash = 0xCEE815614F8FABAF)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource BannerImage;
        /* 0x88 */ public NMSString0x10 LinkedSpecialID;
        /* 0x98 */ public bool WideImage;
        /* 0xA0 */ public NMSString0x20A TipText;
    }
}
