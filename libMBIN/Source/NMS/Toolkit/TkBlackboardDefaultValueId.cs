using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8120304A040520DE, NameHash = 0x51BC6BBE6D56FC99)]
    public class TkBlackboardDefaultValueId : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x18 */ public NMSString0x10 DefaultValue;
    }
}
