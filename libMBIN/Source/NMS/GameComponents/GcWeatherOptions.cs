namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1D57A25C7662EF3, NameHash = 0xA18B4C1D)]
    public class GcWeatherOptions : NMSTemplate
    {
        // size: 0x11
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
            GasGiant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeatherEnum Weather;
    }
}
