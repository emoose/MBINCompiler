using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE82BC2FFD780DC01, NameHash = 0x4452780AB55C81D6)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x000 */ public NMSString0x80[] Table;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x800 */ public GcHazardValues[] DefaultTemperature;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x828 */ public GcHazardValues[] DefaultToxicity;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x850 */ public GcHazardValues[] DefaultRadiation;
    }
}
