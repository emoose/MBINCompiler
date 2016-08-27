namespace MBINCompiler.Models.Structs
{
    public class GcEncounterComponentData : NMSTemplate
    {
        public int EncounterType;
        public string[] EncounterTypeValues()
        {
            return new[] { "Guards", "Patrol", "Ambush" };
        }
        public int EncounterRobot;
        public string[] EncounterRobotValues()
        {
            return new[] { "Drones", "Quads", "Walker" };
        }
        public int CountMin;
        public int CountMax;
    }
}
