namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA49E75B8F788BA8B, NameHash = 0x5D7021FE)]
    public class GcCostHasFireteamMember : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Index;
        [NMS(Index = 1)]
        /* 0x4 */ public bool BlockIfCannotAccessTheirPurpleSystem;
    }
}
