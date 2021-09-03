using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x5C63C59B17C2FBDD, NameHash = 0x894C8A7A0498F6C5)]
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        // size: 0x20
		public enum ScanBuildingIconTypesEnum {
            None, Generic, Shelter, Relic, Factory, Unknown, Distress, Beacon, Waypoint, SpaceStation,
            TechResource, FuelResource, MineralResource, SpaceAnomaly, SpaceAtlas, ExternalBase, PlanetBaseTerminal, Nexus, AbandonedFreighter, Telescope,
            Outpost, UpgradePod, Cog, Ruins, Portal, Library, Abandoned, SmallBuilding, StoryGlitch, GraveInCave,
            HoloHub, Settlement
        }
		public ScanBuildingIconTypesEnum ScanBuildingIconTypes;
    }
}