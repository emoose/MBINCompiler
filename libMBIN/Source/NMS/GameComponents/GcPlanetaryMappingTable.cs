using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A3833F58E5BA5B6, NameHash = 0xB47263D5F2CB7D5D)]
    public class GcPlanetaryMappingTable : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x0 */ public GcPlanetaryMappingValues[] MappingInfo;
    }
}
