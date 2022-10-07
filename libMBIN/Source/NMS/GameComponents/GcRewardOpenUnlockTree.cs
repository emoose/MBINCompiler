using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD411461FAC90C0CB, NameHash = 0x6F44BB3A2BA686D8)]
    public class GcRewardOpenUnlockTree : NMSTemplate
    {
        /* 0x0 */ public GcUnlockableItemTreeGroups TreeToOpen;
        /* 0x4 */ public int PageIndexOverride;
    }
}
