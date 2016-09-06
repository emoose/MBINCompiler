namespace MBINCompiler.Models.Structs
{
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
        public int GlobalMission;

        public string[] GlobalMissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
    }
}
