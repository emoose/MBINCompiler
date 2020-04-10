using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x210, GUID = 0xF5BC9F27DFFC1970)]
    public class GcWaterGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool RenderReflections;
        /* 0x0001 */ public bool UseNewWater;
        /* 0x0004 */ public float WaveHeight;
        /* 0x0008 */ public float WaveFrequency;
        /* 0x000C */ public float WaveChoppiness;
        /* 0x0010 */ public float WaveCutoff;
        /* 0x0014 */ public float Epsilon;
        /* 0x0018 */ public float FresnelPow;
        /* 0x001C */ public float FresnelMul;
        /* 0x0020 */ public float FresnelAlpha;
        /* 0x0024 */ public float FresnelBelowPow;
        /* 0x0028 */ public float FresnelBelowMul;
        /* 0x002C */ public float FresnelBelowAlpha;
        /* 0x0030 */ public Colour WaterHeavyAirColour;
        /* 0x0040 */ public GcPlanetWaterData WaterDataDay;
        /* 0x01C0 */ public GcPlanetWaterColourData WaterColourNight;
    }
}
