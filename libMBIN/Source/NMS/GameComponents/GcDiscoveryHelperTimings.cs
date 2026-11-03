namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCFCE484C653F902, NameHash = 0x66897AC2)]
    public class GcDiscoveryHelperTimings : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float DiscoverPlanetMessageTime;
        [NMS(Index = 1)]
        /* 0x4 */ public float DiscoverPlanetMessageWait;
        [NMS(Index = 0)]
        /* 0x8 */ public float DiscoverPlanetTotalTime;
    }
}
