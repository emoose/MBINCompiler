using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6178063B8375F38E, NameHash = 0x5EE86B02)]
    public class GcPlanetaryMappingValues : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlanetSize PlanetSize;
        [NMS(Index = 2)]
        /* 0x4 */ public ushort PolesPerSection;
        [NMS(Index = 1)]
        /* 0x6 */ public ushort SectionPerSide;
    }
}
