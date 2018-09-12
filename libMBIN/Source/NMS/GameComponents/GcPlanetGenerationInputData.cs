using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x0CA4B078251BAF8BE)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public GcGalaxyStarTypes StarType;
        /* 0x14 */ public GcPlanetClass PlanetClass;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string CommonSubstance;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string RareSubstance;
        /* 0x38 */ public GcPlanetSize PlanetSize;
        /* 0x3C */ public GcBiomeType Biome;
        /* 0x40 */ public int BiomeFileIndex;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
