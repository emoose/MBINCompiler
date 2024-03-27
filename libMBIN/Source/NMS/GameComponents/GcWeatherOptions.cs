namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60CDE501516F083F, NameHash = 0xA2AEA53FED6497EC)]
    public class GcWeatherOptions : NMSTemplate
    {
        // size: 0x10
        public enum WeatherEnum : uint {
            Clear,
            Dust,
            Humid,
            Snow,
            Toxic,
            Scorched,
            Radioactive,
            RedWeather,
            GreenWeather,
            BlueWeather,
            Swamp,
            Lava,
            Bubble,
            Weird,
            Fire,
            ClearCold,
        }
        /* 0x0 */ public WeatherEnum Weather;
    }
}
