namespace MBINCompiler.Models.Structs
{
    public class GcBuildingClassification : NMSTemplate 
    {
		/* 0x000 */ public int BuildingClass;
		public string[] ScanEffectTypeValues()
		{
			return new[] { "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint", "Beacon", "RadioTower" "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith", "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base"};
		}
    }
}
