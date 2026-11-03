using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF2B12A918E6BA9AC, NameHash = 0x61C1515A)]
    public class TkIdModelResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Model;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
    }
}
