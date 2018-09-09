using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x38, GUID = 0x0B9AC8248B97BE97F)]
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public bool OnlyOnExtremeWeather;
        public bool OnlyOnExtremeSentinels;
        public bool OnlyOnDeepWater;
        public bool NotOnExtremePlanets;
        public bool NotOnStartPlanets;

        public GcBiomeType OnlyOnBiome;

        public float ProbabilityOfBeingActive;
        public int MinFilesToChoose;
        public int MaxFilesToChoose;

        public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
}
