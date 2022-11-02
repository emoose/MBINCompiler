using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD15534400E5C7127, NameHash = 0x8E91F497B8C8D2F3)]
    public class TkBlackboardDefaultValueVector : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x20 */ public Vector3f DefaultValue;
    }
}
