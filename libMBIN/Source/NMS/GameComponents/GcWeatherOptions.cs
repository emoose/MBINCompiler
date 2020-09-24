using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x6536C3AF5C4EBF23, NameHash = 0xA2AEA53FED6497EC)]
    public class GcWeatherOptions : NMSTemplate
    {
        // 0xF entries
		public enum WeatherEnum {
            Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather,
            Swamp, Lava, Bubble, Weird, Fire
        }
		public WeatherEnum Weather;
    }
}