namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5E21E940803790E, NameHash = 0xA699A80ACABBB3C5)]
    public class GcPlanetWeatherColourData : NMSTemplate
    {
        /* 0x00 */ public Colour SkyColour;
        /* 0x10 */ public Colour SkyUpperColour;
        /* 0x20 */ public Colour SkySolarColour;
        /* 0x30 */ public Colour HorizonColour;
        /* 0x40 */ public Colour SunColour;
        /* 0x50 */ public Colour FogColour;
        /* 0x60 */ public Colour HeightFogColour;
        /* 0x70 */ public Vector3f SkyGradientSpeed;
        /* 0x80 */ public Colour LightColour;
        /* 0x90 */ public Colour CloudColour1;
        /* 0xA0 */ public Colour CloudColour2;
    }
}
