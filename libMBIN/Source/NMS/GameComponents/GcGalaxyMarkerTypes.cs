namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5BEEDB124B02C9, NameHash = 0x29324EF951272232)]
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        // size: 0x10
        public enum GalaxyMarkerTypeEnum {
            StartingLocation,
            Home,
            Waypoint,
            Contact,
            Blackhole,
            AtlasStation,
            Selection,
            PlanetBase,
            Visited,
            ScanEvent,
            Expedition,
            NetworkPlayer,
            Freighter,
            PathIcon,
            SeasonParty,
            Settlement
        }
        /* 0x0 */ public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}
