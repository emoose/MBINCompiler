using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x3CE3CF6A59E14C41, NameHash = 0xB9F3B9FAC994498B)]
    public class GcRewardSpecificFrigate : NMSTemplate
    {
        /* 0x00 */ public GcFrigateClass FrigateClass;
        /* 0x08 */ public ulong FrigateSeed;
        /* 0x10 */ public ulong SystemSeed;
        /* 0x18 */ public GcAlienRace AlienRace;
        /* 0x20 */ public NMSString0x20A NameOverride;
        /* 0x40 */ public bool IsGift;
        /* 0x41 */ public bool IsRewardFrigate;
        /* 0x42 */ public bool FormatAsSeasonal;
    }
}
