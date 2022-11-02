using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A0B55C4D88F961C, NameHash = 0x4F9FD28121A054A4)]
    public class GcPlanetaryMappingData : NMSTemplate
    {
        /* 0x0 */ public ulong UA;
        /* 0x8 */ public List<GcPlanetSectionData> SectionsData;
    }
}
