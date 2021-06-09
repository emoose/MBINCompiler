using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x800, GUID = 0x32F96608DE1A3DB0, NameHash = 0xD216CE8E772352C)]
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public bool UseWeatherFog;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x011 */ public byte[] Padding11;
        /* 0x014 */ public GcFogProperties Fog;
        /* 0x0F4 */ public GcFogProperties FlightFog;
        /* 0x1D4 */ public GcFogProperties StormFog;
        /* 0x2B4 */ public GcFogProperties ExtremeFog;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x394 */ public byte[] Padding394;
        /* 0x3A0 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        [NMS(Size = 0x4, EnumType = typeof(GcRainbowType.RainbowTypeEnum))]
        /* 0x640 */ public float[] RainbowChance;
        /* 0x650 */ public List<GcStormProperties> Storms;
        /* 0x660 */ public List<NMSString0x80> HeavyAir;
        /* 0x670 */ public float LowStormsChance;
        /* 0x674 */ public float HighStormsChance;
        /* 0x678 */ public float ExtremeWeatherChance;
        /* 0x67C */ public bool OverrideTemperature;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x67D */ public byte[] Padding67D;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x680 */ public GcHazardValues[] Temperature;
        /* 0x6A8 */ public bool OverrideToxicity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x6A9 */ public byte[] Padding6A9;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6AC */ public GcHazardValues[] Toxicity;
        /* 0x6D4 */ public bool OverrideRadiation;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x6D5 */ public byte[] Padding6D5;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x6D8 */ public GcHazardValues[] Radiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.GcHazardValueTypesEnum))]
        /* 0x700 */ public GcHazardValues[] LifeSupportDrain;
        /* 0x728 */ public List<GcScreenFilters> StormFilterOptions;
        /* 0x738 */ public bool UseWeatherSky;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x739 */ public byte[] Padding739;
        /* 0x73C */ public GcSkyProperties Sky;
        /* 0x76C */ public bool UseLightShaftProperties;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x76D */ public byte[] Padding76D;
        /* 0x770 */ public GcLightShaftProperties LightShaftProperties;
        /* 0x7A0 */ public bool UseStormLightShaftProperties;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x7A1 */ public byte[] Padding7A1;
        /* 0x7B0 */ public GcLightShaftProperties StormLightShaftProperties;
        /* 0x7E0 */ public List<NMSString0x10> WeatherEffectsIds;
        /* 0x7F0 */ public List<NMSString0x10> WeatherHazardsIds;
    }
}
