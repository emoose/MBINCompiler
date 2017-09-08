using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcExternalObjectFileList : NMSTemplate     // size: 0x38
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
