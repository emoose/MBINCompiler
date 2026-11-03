namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5409234873ED6C7A, NameHash = 0xB35D5BC6)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        // size: 0x6
        public enum GalaxyWaypointTypeEnum : uint {
            User,
            Gameplay_AtlasStation,
            Gameplay_DistressBeacon,
            Gameplay_BlackHole,
            Gameplay_Mission,
            Gameplay_SeasonParty,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
