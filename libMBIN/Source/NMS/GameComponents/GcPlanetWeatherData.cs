using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E5878876F183984, NameHash = 0xEBF08BE1E3CAE3AC)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        /* 0x000 */ public GcWeatherOptions WeatherType;
        /* 0x010 */ public GcPlanetHeavyAirData HeavyAir;
        // size: 0x2
        public enum WeatherIntensityEnum {
            Default,
            Extreme
        }
        /* 0x130 */ public WeatherIntensityEnum WeatherIntensity;
        // size: 0x3
        public enum StormFrequencyEnum {
            None,
            Low,
            High
        }
        /* 0x134 */ public StormFrequencyEnum StormFrequency;
        // size: 0x2
        public enum AtmosphereTypeEnum {
            None,
            Normal
        }
        /* 0x138 */ public AtmosphereTypeEnum AtmosphereType;
        /* 0x13C */ public int DayColourIndex;
        /* 0x140 */ public int DuskColourIndex;
        /* 0x144 */ public GcScreenFilters ScreenFilter;
        /* 0x148 */ public GcScreenFilters StormScreenFilter;
        /* 0x14C */ public GcRainbowType RainbowType;
        /* 0x150 */ public int NightColourIndex;
    }
}
