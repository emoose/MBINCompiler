using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A8FD6CE8A44A1EC, NameHash = 0xBC5A7B75)]
    public class GcPlanetaryMappingData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcPlanetSectionData> SectionsData;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong UA;
    }
}
