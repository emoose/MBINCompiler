using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94728F707F0B63BD, NameHash = 0x76D3572C2A9662D2)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool OnlyOnExtremeWeather;
        /* 0x11 */ public bool OnlyOnExtremeSentinels;
        /* 0x12 */ public bool OnlyOnCorruptSentinels;
        /* 0x13 */ public bool OnlyOnDeepWater;
        /* 0x14 */ public bool NotOnExtremePlanets;
        /* 0x15 */ public bool NotOnStartPlanets;
        /* 0x16 */ public bool NotOnWeirdPlanets;
        /* 0x17 */ public bool NotOnDeadPlanets;
        /* 0x18 */ public bool ForceOnSeasonStart;
        /* 0x1C */ public GcBiomeType OnlyOnBiome;
        /* 0x20 */ public float ProbabilityOfBeingActive;
        /* 0x24 */ public int MinFilesToChoose;
        /* 0x28 */ public int MaxFilesToChoose;
        /* 0x30 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;
    }
}
