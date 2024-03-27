namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BFC6055460243D3, NameHash = 0x408CCAADC93DEEFE)]
    public class GcPlanetSectionData : NMSTemplate
    {
        /* 0x0 */ public ulong DiscovererUID;
        [NMS(Size = 0x2)]
        /* 0x8 */ public byte[] DiscovererPlatform;
        /* 0xA */ public bool DiscoveredState;
    }
}
