namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A9410B6550F62352)]
    public class GcWeatherOptions : NMSTemplate
    {
		public enum WeatherEnum { Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather }
		public WeatherEnum Weather;
    }
}
