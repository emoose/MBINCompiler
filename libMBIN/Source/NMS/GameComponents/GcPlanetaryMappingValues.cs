using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDD90D922CF9002F, NameHash = 0x314960F4DFCC0B34)]
    public class GcPlanetaryMappingValues : NMSTemplate
    {
        /* 0x0 */ public GcPlanetSize PlanetSize;
        /* 0x4 */ public ushort SectionPerSide;
        /* 0x6 */ public ushort PolesPerSection;
    }
}
