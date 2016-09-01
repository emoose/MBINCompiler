using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcWeatherProperties : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;

        public GcFogProperties Fog;
        public GcFogProperties FlightFog;
        public GcFogProperties StormFog;
        public GcFogProperties ExtremeFog;

        public GcWeatherColourModifiers StormColourModifiers;
        public GcWeatherColourModifiers ExtremeColourModifiers;

        public List<NMSString0x80> HeavyAir;

        public float LowStormsChance;
        public float HighStormsChance;
        public float ExtremeWeatherChance;

        public bool OverrideTemperature;
        public GcHazardValues Temperature1;
        public GcHazardValues Temperature2;
        public GcHazardValues Temperature3;
        public GcHazardValues Temperature4;
        public GcHazardValues Temperature5;

        public bool OverrideToxicity;
        public GcHazardValues Toxicity1;
        public GcHazardValues Toxicity2;
        public GcHazardValues Toxicity3;
        public GcHazardValues Toxicity4;
        public GcHazardValues Toxicity5;

        public bool OverrideRadiation;
        public GcHazardValues Radiation1;
        public GcHazardValues Radiation2;
        public GcHazardValues Radiation3;
        public GcHazardValues Radiation4;
        public GcHazardValues Radiation5;
    }
}
