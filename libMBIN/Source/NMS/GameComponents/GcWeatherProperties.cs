using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFA3F3198B086BA8, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public bool UseWeatherFog;
        /* 0x014 */ public GcFogProperties Fog;
        /* 0x0F4 */ public GcFogProperties FlightFog;
        /* 0x1D4 */ public GcFogProperties StormFog;
        /* 0x2B4 */ public GcFogProperties ExtremeFog;
        /* 0x3A0 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        // size: 0x4
        public enum RainbowChanceEnum {
            Always,
            Occasional,
            Storm,
            None
        }
        [NMS(Size = 0x4, EnumType = typeof(RainbowChanceEnum))]
        /* 0x640 */ public float[] RainbowChance;
        /* 0x650 */ public List<GcStormProperties> Storms;
        /* 0x660 */ public List<NMSString0x80> HeavyAir;
        /* 0x670 */ public float LowStormsChance;
        /* 0x674 */ public float HighStormsChance;
        /* 0x678 */ public float ExtremeWeatherChance;
        /* 0x67C */ public bool OverrideTemperature;
        // size: 0x5
        public enum TemperatureEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(TemperatureEnum))]
        /* 0x680 */ public GcHazardValues[] Temperature;
        /* 0x6A8 */ public bool OverrideToxicity;
        // size: 0x5
        public enum ToxicityEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(ToxicityEnum))]
        /* 0x6AC */ public GcHazardValues[] Toxicity;
        /* 0x6D4 */ public bool OverrideRadiation;
        // size: 0x5
        public enum RadiationEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(RadiationEnum))]
        /* 0x6D8 */ public GcHazardValues[] Radiation;
        // size: 0x5
        public enum LifeSupportDrainEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(LifeSupportDrainEnum))]
        /* 0x700 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x728 */ public List<GcScreenFilters> StormFilterOptions;
        /* 0x738 */ public bool UseWeatherSky;
        /* 0x73C */ public GcSkyProperties Sky;
        /* 0x76C */ public bool UseLightShaftProperties;
        /* 0x770 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x7A0 */ public bool UseStormLightShaftProperties;
        /* 0x7B0 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x7E0 */ public List<NMSString0x10> WeatherEffectsIds;
        /* 0x7F0 */ public List<NMSString0x10> WeatherHazardsIds;
    }
}
