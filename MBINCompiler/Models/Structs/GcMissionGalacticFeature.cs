namespace MBINCompiler.Models.Structs
{
    public class GcMissionGalacticFeature : NMSTemplate
    {
        public int GalacticFeature;
        public string[] GalacticFeatureValues()
        {
            return new[] { "Anomaly", "Atlas", "BlackHole"};
        }
    }
}
