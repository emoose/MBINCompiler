using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53549AB5D0471188, NameHash = 0x4F9FD28121A054A4)]
    public class GcPlanetaryMappingData : NMSTemplate
    {
        /* 0x0 */ public ulong UA;
        /* 0x8 */ public List<GcPlanetSectionData> SectionsData;
    }
}
