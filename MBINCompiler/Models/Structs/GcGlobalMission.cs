namespace MBINCompiler.Models.Structs
{
    public class GcGlobalMission : NMSTemplate
    {
        public int Mission;

        public string[] MissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
    }
}
