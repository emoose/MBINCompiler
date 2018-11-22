using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x8DD8A6B4B649C764)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        /* 0x10 */ public bool OnlyOnExtremeWeather;
        /* 0x11 */ public bool OnlyOnExtremeSentinels;
        /* 0x12 */ public bool OnlyOnDeepWater;
        /* 0x13 */ public bool NotOnExtremePlanets;
        /* 0x14 */ public bool NotOnStartPlanets;
        /* 0x15 */ public bool NotOnWeirdPlanets;


        /* 0x18 */ public GcBiomeType OnlyOnBiome;

        /* 0x1C */ public float ProbabilityOfBeingActive;
        /* 0x00 */ public int MinFilesToChoose;
        /* 0x00 */ public int MaxFilesToChoose;

        /* 0x00 */ public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
}
