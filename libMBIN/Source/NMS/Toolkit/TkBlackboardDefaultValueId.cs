using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x120318BB83B9E60A, NameHash = 0xEEC65302)]
    public class TkBlackboardDefaultValueId : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 DefaultValue;
        [NMS(Index = 0)]
        /* 0x20 */ public TkBlackboardCategory BlackboardCategory;
    }
}
