using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B865CF254C13DD0, NameHash = 0x719D093BDEC85E0D)]
    public class GcRewardSetInteractionSeenBitmask : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public int OverrideIndex;
        /* 0x8 */ public NMSString0x10 Stat;
    }
}
