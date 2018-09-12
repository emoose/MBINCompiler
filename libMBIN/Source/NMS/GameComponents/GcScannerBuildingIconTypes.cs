namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x41D88331C68B32DC)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
		public enum ScanBuildingIconTypesEnum { None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation, TechResource, FuelResource, MineralResource, SpaceAnomaly, SapceAtlas }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}
