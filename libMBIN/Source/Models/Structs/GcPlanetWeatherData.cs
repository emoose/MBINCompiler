namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x150)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        public GcWeatherOptions WeatherOptions;     // weather type?
        //public GcPlanetWeatherColourData NightColours;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        /* 0x010 */ public GcPlanetHeavyAirData HeavyAir;
        /* 0x130 */ public int WeatherIntensity;
        public string[] WeatherIntensityValues()
        {
            return new[] { "Default", "Extreme" };
        }
        /* 0x134 */ public int StormFrequency;
        public string[] StormFrequencyValues()
        {
            return new[] { "None", "Low", "High" };
        }
        /* 0x138 */ public int AtmosphereType;
        public string[] AtmosphereTypeValues()
        {
            return new[] { "None", "Normal" };
        }
        /* 0x13C */ public int DayColourIndex;
        /* 0x140 */ public int DuskColourIndex;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x144 */ public byte[] EndPadding;
    }
}
