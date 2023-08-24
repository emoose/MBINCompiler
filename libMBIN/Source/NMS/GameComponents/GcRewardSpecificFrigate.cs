using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DC8CE7827F7AD94, NameHash = 0xB9F3B9FAC994498B)]
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
        /* 0x43 */ public bool UseSeedFromCommunicator;
        /* 0x48 */ public NMSString0x10 PrimaryTrait;
    }
}
