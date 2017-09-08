namespace libMBIN.Models.Structs
{
    public class GcPlanetWeatherColourIndex : NMSTemplate       // size: 0x8
    {
        public int WeatherColourSet;
        public string[] WeatherColourSetValues()
        {
            return new[] { "Common", "Rare" };
        }
        public int Index;
    }
}
