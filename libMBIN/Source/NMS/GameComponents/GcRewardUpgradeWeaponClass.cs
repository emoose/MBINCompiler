namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0E4DD0278BBC3EB, NameHash = 0x591B28B5)]
    public class GcRewardUpgradeWeaponClass : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool MatchClassToCommunityTier;
        [NMS(Index = 0)]
        /* 0x1 */ public bool Silent;
        [NMS(Index = 2)]
        /* 0x2 */ public bool SilentlyMoveOnAtMaxClass;
    }
}
