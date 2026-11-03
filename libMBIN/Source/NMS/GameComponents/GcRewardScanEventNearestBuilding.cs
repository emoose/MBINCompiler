namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7B23D3FC76090F0, NameHash = 0x78A5C570)]
    public class GcRewardScanEventNearestBuilding : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool DoAerialScan;
        [NMS(Index = 1)]
        /* 0x1 */ public bool IncludeVisited;
    }
}
