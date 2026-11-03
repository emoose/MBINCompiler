namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26DFC61E13EB59E0, NameHash = 0x2547FA1E)]
    public class GcRewardWeaponSlot : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Cost;
        [NMS(Index = 2)]
        /* 0x10 */ public int NumTokens;
        [NMS(Index = 1)]
        /* 0x14 */ public bool AwardCostAndOpenWindow;
    }
}
