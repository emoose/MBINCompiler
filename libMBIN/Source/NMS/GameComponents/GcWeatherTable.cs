using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6A8C554E22D192C, NameHash = 0x1754D309)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcWeatherOptions.WeatherEnum))]
        /* 0x000 */ public GcFilename[] Table;
        [NMS(Index = 3, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x110 */ public GcHazardValues[] DefaultRadiation;
        [NMS(Index = 4, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x140 */ public GcHazardValues[] DefaultSpookLevel;
        [NMS(Index = 1, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x170 */ public GcHazardValues[] DefaultTemperature;
        [NMS(Index = 2, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x1A0 */ public GcHazardValues[] DefaultToxicity;
    }
}
