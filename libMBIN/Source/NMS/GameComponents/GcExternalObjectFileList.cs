using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8136D801B37E866, NameHash = 0x8710D808)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
        [NMS(Index = 15)]
        /* 0x10 */ public List<int> ForceOnDuringSeasons;
        [NMS(Index = 14)]
        /* 0x20 */ public List<int> ForceOnSeasonStartPlanet;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Id;
        [NMS(Index = 17, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x40 */ public float[] SubBiomeProbability;
        [NMS(Index = 20)]
        /* 0xC0 */ public int MaxFilesToChoose;
        [NMS(Index = 19)]
        /* 0xC4 */ public int MinFilesToChoose;
        [NMS(Index = 16)]
        /* 0xC8 */ public GcBiomeType OnlyOnBiome;
        [NMS(Index = 18)]
        /* 0xCC */ public float ProbabilityOfBeingActive;
        [NMS(Index = 11)]
        /* 0xD0 */ public bool NotOnDeadPlanets;
        [NMS(Index = 8)]
        /* 0xD1 */ public bool NotOnExtremePlanets;
        [NMS(Index = 12)]
        /* 0xD2 */ public bool NotOnGasGiant;
        [NMS(Index = 13)]
        /* 0xD3 */ public bool NotOnInfested;
        [NMS(Index = 7)]
        /* 0xD4 */ public bool NotOnScrapWorlds;
        [NMS(Index = 9)]
        /* 0xD5 */ public bool NotOnStartPlanets;
        [NMS(Index = 10)]
        /* 0xD6 */ public bool NotOnWeirdPlanets;
        [NMS(Index = 3)]
        /* 0xD7 */ public bool OnlyOnCorruptSentinels;
        [NMS(Index = 4)]
        /* 0xD8 */ public bool OnlyOnDeepWater;
        [NMS(Index = 2)]
        /* 0xD9 */ public bool OnlyOnExtremeSentinels;
        [NMS(Index = 1)]
        /* 0xDA */ public bool OnlyOnExtremeWeather;
        [NMS(Index = 5)]
        /* 0xDB */ public bool OnlyOnInfested;
        [NMS(Index = 6)]
        /* 0xDC */ public bool OnlyOnScrapWorlds;
    }
}
