using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x22AC83E6441380D5, NameHash = 0x2FAF5D4269DCB98C)]
    public class TkBlackboardDefaultValueInteger : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x18 */ public int DefaultValue;
    }
}
