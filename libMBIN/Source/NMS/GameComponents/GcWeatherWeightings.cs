using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3694978110105288, SubGUID = 0x95130A2823DE5833)]
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS(Size = 10, EnumValue = new[] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive", "RedWeather", "GreenWeather", "BlueWeather" })]
        /* 0x380 */ public float[] WeatherWeightings;
    }
}
