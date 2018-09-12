using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x939065160F0053B4)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
		public enum GalaxyMarkerTypeEnum { StartingLocation, Home, Waypoint, Contact, Blackhole, AtlasStation, Selection, PlanetBase, Visited, ScanEvent }
		public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}
