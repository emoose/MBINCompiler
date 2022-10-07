namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3694978110105288, NameHash = 0x95130A2823DE5833)]
    public class GcWeatherWeightings : NMSTemplate
    {
        // size: 0x10
        public enum WeatherWeightingsEnum {
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
            ClearCold
        }
        [NMS(Size = 0x10, EnumType = typeof(WeatherWeightingsEnum))]
        /* 0x0 */ public float[] WeatherWeightings;
    }
}
