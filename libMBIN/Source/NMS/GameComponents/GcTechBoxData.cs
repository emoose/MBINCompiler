using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA8, GUID = 0x98027365AE18C92C, NameHash = 0x3839C255F197D92C)]
    public class GcTechBoxData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public NMSString0x10 InstallTechID;
        /* 0x20 */ public TkTextureResource Icon;
    }
}
