using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x522B03A8674FB1CC, NameHash = 0xE2296648)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public GcBiomeType PlanetBiomeRequirement;
        [NMS(Index = 2)]
        /* 0x4 */ public GcPlayerHazardType PlanetWeatherRequirement;
        [NMS(Index = 0)]
        /* 0x8 */ public bool RequiresExtremePlanet;
        [NMS(Index = 1)]
        /* 0x9 */ public bool UseStrictSkyExtremeTest;
    }
}
