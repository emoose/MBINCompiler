namespace MBINCompiler.Models.Structs
{
    public class GcPlanetWeatherData : NMSTemplate
    {
        public GcWeatherOptions WeatherOptions;
        public GcPlanetWeatherColourData NightColours;
        public GcPlanetHeavyAirData HeavyAir;
        public float NightDensity;
        public int WeatherIntensity;
        public string[] WeatherIntensityValues()
        {
            return new[] { "Default", "Extreme" };
        }
        public int StormFrequency;
        public string[] StormFrequencyValues()
        {
            return new[] { "None", "Low", "High" };
        }
        public int AtmosphereType;
        public string[] AtmosphereTypeValues()
        {
            return new[] { "None", "Normal" };
        }
        public int DayColourIndex;
        public int DuskColourIndex;
        public int NightColourIndex;
    }
}
