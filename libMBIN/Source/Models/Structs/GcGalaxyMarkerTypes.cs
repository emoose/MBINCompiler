namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x939065160F0053B4)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
		public enum GalaxyMarkerTypeEnum { StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase, Visited, ScanEvent }
		public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}
