using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF84901AAADDB1426, NameHash = 0xB22694B55382153C)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        /* 0x0 */ public bool RequiresExtremePlanet;
        /* 0x4 */ public GcPlayerHazardType PlanetWeatherRequirement;
        /* 0x8 */ public GcBiomeType PlanetBiomeRequirement;
    }
}
