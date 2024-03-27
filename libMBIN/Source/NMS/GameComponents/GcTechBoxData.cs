using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD016B8C23D28332A, NameHash = 0x3839C255F197D92C)]
    public class GcTechBoxData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public NMSString0x10 InstallTechID;
        /* 0x20 */ public TkTextureResource Icon;
        /* 0xA4 */ public bool IsAlien;
    }
}
