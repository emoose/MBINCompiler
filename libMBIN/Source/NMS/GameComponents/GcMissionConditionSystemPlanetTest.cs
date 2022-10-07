using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26E11953489FD24C, NameHash = 0xB22694B55382153C)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        /* 0x0 */ public bool RequiresExtremePlanet;
        /* 0x4 */ public GcPlayerHazardType PlanetWeatherRequirement;
    }
}
