using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC68FC2901C46C4FD, NameHash = 0xFB06554B7F990F81)]
    public class TkBlackboardDefaultValueBool : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x18 */ public bool DefaultValue;
    }
}
