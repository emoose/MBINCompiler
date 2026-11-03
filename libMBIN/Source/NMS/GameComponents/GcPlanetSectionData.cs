namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACC44712BED18EBC, NameHash = 0x34B5F884)]
    public class GcPlanetSectionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong DiscovererUID;
        [NMS(Index = 1, Size = 0x2)]
        /* 0x8 */ public byte[] DiscovererPlatform;
        [NMS(Index = 2)]
        /* 0xA */ public bool DiscoveredState;
    }
}
