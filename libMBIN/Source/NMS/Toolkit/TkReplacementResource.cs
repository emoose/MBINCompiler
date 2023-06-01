using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B7F822770CF00D, NameHash = 0xC683578709BD3232)]
    public class TkReplacementResource : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource Original;
        /* 0x84 */ public TkTextureResource Replacement;
    }
}
