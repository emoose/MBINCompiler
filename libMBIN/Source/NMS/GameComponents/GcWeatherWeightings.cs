using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9634CCE8F5EDB6A2, NameHash = 0x908843AB)]
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x0 */ public float[] WeatherWeightings;
    }
}
