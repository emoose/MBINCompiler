using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C165E9E78D00C95, NameHash = 0x710A6CDD7B84F22B)]
    public class GcRewardUpgradeShipClass : NMSTemplate
    {
        /* 0x0 */ public bool Silent;
        /* 0x4 */ public GcInventoryClass ForceToSpecificClass;
        /* 0x8 */ public bool MatchClassToCommunityTier;
    }
}
