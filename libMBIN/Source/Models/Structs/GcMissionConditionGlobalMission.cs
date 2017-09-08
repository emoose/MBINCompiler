namespace libMBIN.Models.Structs
{
    public class GcMissionConditionGlobalMission : NMSTemplate
    {
        // I *think* this should be embedded in another struct, but this should have the same effect...
        public int GlobalMission;
        public string[] GlobalMissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
    }
}
