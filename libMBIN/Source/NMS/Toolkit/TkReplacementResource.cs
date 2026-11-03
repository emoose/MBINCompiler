using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA9AA400E70C75771, NameHash = 0x2C70ACC)]
    public class TkReplacementResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkTextureResource Original;
        [NMS(Index = 1)]
        /* 0x18 */ public TkTextureResource Replacement;
    }
}
