namespace MBINCompiler.Models.Structs
{
    public class GcScanType : NMSTemplate
    {
        public int Type;

        public string[] TypeValues()
        {
            return new[] { "Tool", "Beacon", "RadioTower", "Observatory", "DistressSignal", "Waypoint", "Ship", "DebugPlanet", "DebugSpace" };
        }
    }
}
