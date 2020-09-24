using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x7F8, GUID = 0xEB1DFB8AFF12B189, NameHash = 0x4452780AB55C81D6)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Size = 0xF, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x000 */ public NMSString0x80[] Table;
        [NMS(Size = 5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x780 */ public GcHazardValues[] DefaultTemperature;
        [NMS(Size = 5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x7A8 */ public GcHazardValues[] DefaultToxicity;
        [NMS(Size = 5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x7D0 */ public GcHazardValues[] DefaultRadiation;
    }
}