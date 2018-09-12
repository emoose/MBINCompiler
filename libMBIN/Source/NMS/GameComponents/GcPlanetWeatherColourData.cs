namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E5E21E940803790E)]
    public class GcPlanetWeatherColourData : NMSTemplate        // size: 0xB0
    {
        public Colour SkyColour;
        public Colour SkyUpperColour;
        public Colour SkySolarColour;
        public Colour HorizonColour;
        public Colour SunColour;
        public Colour FogColour;
        public Colour HeightFogColour;
        public Vector4f SkyGradientSpeed;
        public Colour LightColour;
        public Colour CloudColour1;
        public Colour CloudColour2;
    }
}
