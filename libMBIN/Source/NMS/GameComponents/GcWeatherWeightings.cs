using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x3694978110105288, NameHash = 0x95130A2823DE5833)]
    public class GcWeatherWeightings : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x0 */ public float[] WeatherWeightings;
    }
}