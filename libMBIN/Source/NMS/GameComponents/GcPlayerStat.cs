using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD8326CF9C4340A9, NameHash = 0x386029983CBEF506)]
    public class GcPlayerStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcStatValueData Value;
    }
}
