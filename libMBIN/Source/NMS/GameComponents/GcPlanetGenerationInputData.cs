using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0xDE8BF371F6565035, SubGUID = 0x2E161A5A69971115)]
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public GcGalaxyStarTypes Star;
        /* 0x14 */ public GcPlanetClass Class;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string CommonSubstance;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string RareSubstance;
        /* 0x38 */ public GcPlanetSize PlanetSize;
        /* 0x3C */ public GcBiomeType Biome;
        /* 0x40 */ public GcBiomeSubType BiomeSubType;
        /* 0x45 */ public bool HasRings;
        /* 0x46 */ public bool ForceContinents;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] EndPadding;
    }
}
