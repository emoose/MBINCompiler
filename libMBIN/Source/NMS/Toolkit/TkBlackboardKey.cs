using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8947A8185E5DE602, NameHash = 0x388ED0AC2B4CA0A6)]
    public class TkBlackboardKey : NMSTemplate
    {
        /* 0x0 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x8 */ public NMSString0x10 BlackboardKey;
    }
}
