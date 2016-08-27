using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models.Structs
{
    public class GcExternalObjectFileList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public bool OnlyOnExtremeWeather;
        public bool OnlyOnExtremeSentinels;
        public bool OnlyOnDeepWater;
        public bool NotOnExtremePlanets;
        public bool NotOnStartPlanets;

        public GcBiomeType Biome;

        public float ProbabilityOfBeingActive;
        public int MinFilesToChoose;
        public int MaxFilesToChoose;

        public List<GcExternalObjectListOptions> ExternalObjectFiles;

    }
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 9)]
        public NMSString0x80[] BiomeFiles;

        public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
