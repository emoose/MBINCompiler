namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F330ED596147E90, NameHash = 0x2179CD2A)]
    public class GcPlanetaryBuildingRestrictions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool RequiresCorruptSentinels;
        [NMS(Index = 2)]
        /* 0x1 */ public bool RequiresRelicWorld;
        [NMS(Index = 3)]
        /* 0x2 */ public bool RequiresScrapWorld;
        [NMS(Index = 1)]
        /* 0x3 */ public bool RequiresWater;
    }
}
