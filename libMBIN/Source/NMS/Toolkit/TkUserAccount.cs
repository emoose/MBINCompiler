using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDB6D784C01241FEB, NameHash = 0x82137623)]
    public class TkUserAccount : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkPlatformGroup PlatformGroup;
        [NMS(Index = 1)]
        /* 0x4 */ public NMSString0x40 OnlineID;
    }
}
