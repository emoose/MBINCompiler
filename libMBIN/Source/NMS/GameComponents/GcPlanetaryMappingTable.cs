using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAB1EDB752EADD76, NameHash = 0xA6915D9C)]
    public class GcPlanetaryMappingTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5)]
        /* 0x0 */ public GcPlanetaryMappingValues[] MappingInfo;
    }
}
